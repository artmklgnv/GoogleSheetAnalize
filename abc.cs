using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Collections.Extensions;

namespace GoogleSheetAnalizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> data = new List<string>();
            List<bool> data_bool = new List<bool>();
            data.Add("001");
            data.Add("001.001");
            data.Add("001.001.001");
            data.Add("001.001.001.001"); //element
            data.Add("001.001.001.002"); //element
            data.Add("001.001.001.003"); //element
            data.Add("001.001.002");
            data.Add("001.001.002.001"); 
            data.Add("001.001.002.002"); //element
            data.Add("001.002");
            data.Add("001.002.001");
            data.Add("001.002.001.001"); //element
            data.Add("001.003");
            data.Add("001.003.001");
            data.Add("001.003.001.001"); //element
            data.Add("001.003.001.002"); //element
            data.Add("001.004");
            data.Add("001.004.001");
            data.Add("001.004.001.001");//element
            data.Add("002");
            data.Add("002.001");
            data.Add("002.001.001");//element
            data.Add("002.002");
            data.Add("003");
            data.Add("003.001");
            data.Add("003.002");
            data.Add("003.003");
            data.Add("003.004");
            data.Add("003.004.001"); //element

            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(true); //element
            data_bool.Add(true); //element
            data_bool.Add(true); //element
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(true); //element
            data_bool.Add(false);
            data_bool.Add(true); //element
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(true); //element
            data_bool.Add(true); //element
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(true);//element
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(true);//element
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(false);
            data_bool.Add(true); //element

            var data_elements = new List<string>();
            var data_group_names = new List<string>();
            for (int i = 0; i < data_bool.Count(); i++)
            {
                if (data_bool[i] == true)
                    data_elements.Add(data[i]);
                else
                    data_group_names.Add(data[i]);
            }


            //listBox1.Items.Add(main_dict.Values.ToList()[0].Count());
            //listBox1.Items.Add(a);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
