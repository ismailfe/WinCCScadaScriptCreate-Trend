using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IDExcel;

namespace ScriptCreate___Trend
{
    public partial class Form1 : Form
    {
        IDExcel.EXL EXL = new IDExcel.EXL();
        public Form1()
        {
            InitializeComponent();
        }
        private void B_DosyaAc_Click(object sender, EventArgs e)
        {
            TB_Status.Text = EXL.READ_ExcelFile(DGV1, TB_DosyaYolu.Text, false, CB_Sayfa);
        }
        private void B_DosyaSec_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            fd.Filter = "Excel Dosyası|*.xls";
            fd.FilterIndex = 1;
            fd.ShowDialog();

            if (fd.CheckPathExists)
            {
                TB_DosyaYolu.Text = fd.FileName.ToString();
                TB_Status.Text = EXL.READ_ExcelFile(DGV1, TB_DosyaYolu.Text, CHB_ilksatir.Checked, CB_Sayfa);
            }
        }
        private void B_ClassOlustur_Click(object sender, EventArgs e)
        {
            create();
        }


        void create()
        {
            TB_Class_ValueSet.Clear();
            TB_Class_ValueSet.Text +=    "Dim objTrendControl"  + Environment.NewLine +
                                         "Dim objTrendWindow"   + Environment.NewLine +
                                         "Dim objTimeAxis"      + Environment.NewLine +
                                         "Dim objValueAxis"     + Environment.NewLine +
                                         "Dim objTrend"         + Environment.NewLine + Environment.NewLine +
                                         "'TREND KONTROL OBJECT NAME" + Environment.NewLine +
                                         "Set objTrendControl = ScreenItems(\"Trend1\") " + Environment.NewLine + Environment.NewLine +
                                         "'CREATE reference to new window, time and value axis" + Environment.NewLine +
                                         "  Set objTrendWindow = objTrendControl.GetTrendWindowCollection.Item(\"Win\")" + Environment.NewLine +
                                         "  Set objTimeAxis = objTrendControl.GetTimeAxisCollection.Item(\"Time\")" + Environment.NewLine +
                                         "  Set objValueAxis = objTrendControl.GetValueAxisCollection.Item(\"Value\")" + Environment.NewLine + Environment.NewLine +
                                         "'ASSING time and value axis to the window" + Environment.NewLine +
                                         "  objTimeAxis.TrendWindow = objTrendWindow.Name" + Environment.NewLine +
                                         "  objValueAxis.TrendWindow = objTrendWindow.Name" + Environment.NewLine +
                                         "  '#########################################################################" + Environment.NewLine +
                                         "  '#########################################################################" + Environment.NewLine + Environment.NewLine;

            Random RandomNum = new Random();


            for (int i = 0; i < DGV1.RowCount - 1; i++)
            {
              
                // LİSTEDEKİ DEĞİŞKENLERİ TESPİT ET (null Değilse)
                if (DGV1.Rows[i].Cells[0].Value != null && DGV1.Rows[i].Cells[1].Value != null && DGV1.Rows[i].Cells[2].Value != null)
                {
                    // LİSTEDEKİ DEĞİŞKENLERİ TESPİT ET (boş Değilse)
                    if (DGV1.Rows[i].Cells[0].Value.ToString() != "" && DGV1.Rows[i].Cells[1].Value.ToString() != "")
                    {
                 

                        int Color1 = RandomNum.Next(0, 255);
                        int Color2 = RandomNum.Next(0, 255);
                        int Color3 = RandomNum.Next(0, 255);

                        if (DGV1.Rows[i].Cells[2].Value.ToString() != "")
                        {
                            TB_Class_ValueSet.Text += Trend(i, DGV1.Rows[i].Cells[0].Value.ToString(), DGV1.Rows[i].Cells[1].Value.ToString(), DGV1.Rows[i].Cells[2].Value.ToString(), Color1, Color2, Color3);
                        }
                        else
                        {
                            TB_Class_ValueSet.Text += Trend(i, DGV1.Rows[i].Cells[0].Value.ToString(), DGV1.Rows[i].Cells[1].Value.ToString(), DGV1.Rows[i].Cells[1].Value.ToString(), Color1, Color2, Color3);
                        }
                      
                    }
                }
            }
        }


        string Trend(int No, string ArchiveName, string Tag, string TagName, int color1, int color2, int color3)
        {
            string str =    "'NEW TREND " + No.ToString() + Environment.NewLine +
                            "Set objTrend = objTrendControl.GetTrendCollection.AddItem(\"" + TagName + "\") " + Environment.NewLine +
                            "objTrend.Provider = 1" + Environment.NewLine +
                            "objTrend.TagName =\"" + ArchiveName +  "\\" + Tag + "\"" + Environment.NewLine +
                            "objTrend.Color = RGB("+ color1.ToString() + "," + color2.ToString() + ", "+ color3.ToString() + ")" + Environment.NewLine +
                            "objTrend.TrendWindow = objTrendWindow.Name" + Environment.NewLine +
                            "objTrend.TimeAxis = objTimeAxis.Name" + Environment.NewLine +
                            "objTrend.ValueAxis = objValueAxis.Name" + Environment.NewLine + Environment.NewLine;
            return str;
        }








    }
}
