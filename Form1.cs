using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Kodama_Xml_Control
{
    public partial class Form1 : Form
    {
        string line = string.Empty;
        string[] files_dragdrop;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_drag_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void textBox_drag__DragDrop(object sender, DragEventArgs e)
        {
            files_dragdrop = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            lbl_name_file.Text = files_dragdrop[0];
            TextBox dragdrop = textBox_drag;
            ReadFileLine(files_dragdrop, dragdrop);
        }
        private void ReadFileLine(string[] files_dragdrop, TextBox dragdrop)
        {
            //leer el archivo
            StreamReader file_read = File.OpenText(files_dragdrop[0]);
            try
            {
                dragdrop.Text = string.Empty;
                while ((line = file_read.ReadLine()) != null)
                {
                    dragdrop.Text += line + "\r\n";
                }
            }
            catch { }
        }

        private void button_save_file_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (lbl_name_file.Text == "Drag file in box")
            {
                MessageBox.Show("DragDrop file", "Info");
            }
            else
            {
                saveFileDialog1.InitialDirectory = lbl_name_file.Text;
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.Filter = "All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = lbl_name_file.Text + "-copy";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //textBox1.Text = saveFileDialog1.FileName;
                    //File.WriteAllText(saveFileDialog1.FileName, textBox_drag.Text);
                    //IEnumerable<string> texttofile = textBox_drag.Text.;
                    //File.AppendAllLines(saveFileDialog1.FileName, texttofile);
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.WriteLine(textBox_next.Text);
                    }
                }
            }
        }

        private void button_translate_Click(object sender, EventArgs e)
        {
            textBox_next.Text = string.Empty;
            //textBox_next.Text = TranslateText("","en","es");
            try
            {
                TextBox dragdrop = textBox_next;
                ReadFileLineToTranslate(files_dragdrop, dragdrop, textBox_language_ori.Text.Trim(), textBox_language_des.Text.Trim());
            }
            catch
            {
                MessageBox.Show("Select File", "Error");
            }


        }
        private void ReadFileLineToTranslate(string[] files_dragdrop, TextBox dragdrop, string language_ori, string language_dest)
        {
            //control tag
            string tag_start = textBox_tag.Text.Trim();
            string tag_finish = ConverTagInitialtofinal(textBox_tag.Text, 1);
            string symbol_1 = textBox_ignore_txt.Text.Trim();
            //leer el archivo
            StreamReader file_read = File.OpenText(files_dragdrop[0]);

            try
            {
                while ((line = file_read.ReadLine()) != null)
                {
                    if (line.StartsWith(tag_start))
                    {
                        string textNotTag = line.Replace(tag_start, "");
                        textNotTag = textNotTag.Replace(tag_finish, "");
                        //symbol1
                        if (textNotTag.Contains(symbol_1) && textBox_ignore_txt.Text.Trim() != "" && textBox_ignore_txt.Text != null)
                        {
                            string firtsTXt = textNotTag;
                            textNotTag = textNotTag.Replace(symbol_1, "123456789123456789123456789");

                            if (textNotTag.Contains("&")) {
                               // textNotTag = TranslateText(textNotTag, language_ori, language_dest);
                                dragdrop.Text += tag_start + firtsTXt + tag_finish + "\r\n";
                            }
                            else {
                                textNotTag = TranslateText(textNotTag, language_ori, language_dest);
                                string final_txt = textNotTag.Replace("123456789123456789123456789", symbol_1);
                                dragdrop.Text += tag_start + final_txt + tag_finish + "\r\n";
                            }

                        }
                        else
                        {
                            if (textNotTag.Contains("&"))
                            {
                                dragdrop.Text += tag_start + textNotTag + tag_finish + "\r\n";
                            }
                            else {
                                textNotTag = TranslateText(textNotTag, language_ori, language_dest);
                                dragdrop.Text += tag_start + textNotTag + tag_finish + "\r\n";
                            }
                                //print el text translated
                                
                           
                        }
                        //symbols

                    }
                    else
                    {
                        dragdrop.Text += line + "\r\n";
                    }

                }
            }
            catch { }
        }

        private string ConverTagInitialtofinal(string tag_final, int position)
        {

            string alpha = tag_final;
            var builder = new StringBuilder();
            int count = 0;
            bool finish = false;

            foreach (var c in alpha)
            {
                builder.Append(c);
                if ((++count % position) == 0)
                {
                    if (!finish)
                    {
                        builder.Append('/');
                        finish = true;
                    }
                }
            }
            Console.WriteLine("Before: {0}", alpha);
            alpha = builder.ToString();
            Console.WriteLine("After: {0}", alpha);
            return alpha;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public string TranslateText(string input, string orig_language, string dest_language)
        {
            // Set the language from/to in the url (or pass it into this function)
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             orig_language, dest_language, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;

            // Get all json data
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

            // Extract just the first array element (This is the only data we are interested in)
            var translationItems = jsonData[0];

            // Translation Data
            string translation = "";

            // Loop through the collection extracting the translated objects
            foreach (object item in translationItems)
            {
                // Convert the item array to IEnumerable
                IEnumerable translationLineObject = item as IEnumerable;

                // Convert the IEnumerable translationLineObject to a IEnumerator
                IEnumerator translationLineString = translationLineObject.GetEnumerator();

                // Get first object in IEnumerator
                translationLineString.MoveNext();

                // Save its value (translated text)
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };

            // Return translation
            return translation;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
