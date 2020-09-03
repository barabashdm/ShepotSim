using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using Microsoft.Office.Interop.Word;

namespace ShepotSim
{

    public partial class Form1 : Form
    {
        private readonly string TemplateFileName = Environment.CurrentDirectory + "\\Шаблон.docx";

        public Form1()
        {
            InitializeComponent();
            comboBoxSpeechLevel.Items.AddRange(new object[2]
            {
                "70 дБ",
                "84 дБ"
            });
            Ltc = new List<TextBox>
            {
                tBLtc1,
                tBLtc2,
                tBLtc3,
                tBLtc4,
                tBLtc5,
                tBLtc6,
                tBLtc7
            };
            Lsh = new List<TextBox>
            {
                tBLsh1,
                tBLsh2,
                tBLsh3,
                tBLsh4,
                tBLsh5,
                tBLsh6,
                tBLsh7
            };
            Lh = new List<TextBox>
            {
                tBLh1,
                tBLh2,
                tBLh3,
                tBLh4,
                tBLh5,
                tBLh6,
                tBLh7
            };
            Lsaz = new List<TextBox>
            {
                tBLsaz1,
                tBLsaz2,
                tBLsaz3,
                tBLsaz4,
                tBLsaz5,
                tBLsaz6,
                tBLsaz7
            };
            Lc1 = new List<TextBox>
            {
                tBLc11,
                tBLc12,
                tBLc13,
                tBLc14,
                tBLc15,
                tBLc16,
                tBLc17
            };
            Qi = new List<TextBox>
            {
                tBQ1,
                tBQ2,
                tBQ3,
                tBQ4,
                tBQ5,
                tBQ6,
                tBQ7
            };
            N = new List<TextBox>
            {
                tBN1,
                tBN2,
                tBN3,
                tBN4,
                tBN5,
                tBN6,
                tBN7
            };
            R1 = new List<TextBox>
            {
                tBR11,
                tBR12,
                tBR13,
                tBR14,
                tBR15,
                tBR16,
                tBR17
            };
            Lc2 = new List<TextBox>
            {
                tBLc21,
                tBLc22,
                tBLc23,
                tBLc24,
                tBLc25,
                tBLc26,
                tBLc27
            };
            E = new List<TextBox>
            {
                tBE1,
                tBE2,
                tBE3,
                tBE4,
                tBE5,
                tBE6,
                tBE7
            };
            q = new List<TextBox>
            {
                tBqi1,
                tBqi2,
                tBqi3,
                tBqi4,
                tBqi5,
                tBqi6,
                tBqi7
            };
            p = new List<TextBox>
            {
                tBp1,
                tBp2,
                tBp3,
                tBp4,
                tBp5,
                tBp6,
                tBp7
            };
            k = new List<TextBox>
            {
                tBk1,
                tBk2,
                tBk3,
                tBk4,
                tBk5,
                tBk6,
                tBk7
            };
            r = new List<TextBox>
            {
                tBr1,
                tBr2,
                tBr3,
                tBr4,
                tBr5,
                tBr6,
                tBr7
            };
            E2 = new List<TextBox>
            {
                tBEi21,
                tBEi22,
                tBEi23,
                tBEi24,
                tBEi25,
                tBEi26,
                tBEi27
            };
            NormMeas = new List<TextBox>
            {
                tBNormMeas1,
                tBNormMeas2,
                tBNormMeas3,
                tBNormMeas4,
                tBNormMeas5,
                tBNormMeas6,
                tBNormMeas7
            };
            NormMeas2 = new List<TextBox>
            {
                tBNormMeas21,
                tBNormMeas22,
                tBNormMeas23,
                tBNormMeas24,
                tBNormMeas25,
                tBNormMeas26,
                tBNormMeas27
            };
            NeedCorrect = new List<TextBox>
            {
                tBNeedCorrect1,
                tBNeedCorrect2,
                tBNeedCorrect3,
                tBNeedCorrect4,
                tBNeedCorrect5,
                tBNeedCorrect6,
                tBNeedCorrect7
            };
            PovDatamVPa1 = new List<TextBox>
            {
                tBPovDatamVPa11,
                tBPovDatamVPa12,
                tBPovDatamVPa13,
                tBPovDatamVPa14,
                tBPovDatamVPa15,
                tBPovDatamVPa16,
                tBPovDatamVPa17
            };
            PovDatadB1 = new List<TextBox>
            {
                tBPovDatadB11,
                tBPovDatadB12,
                tBPovDatadB13,
                tBPovDatadB14,
                tBPovDatadB15,
                tBPovDatadB16,
                tBPovDatadB17
            };
            PovDatamVPa2 = new List<TextBox>
            {
                tBPovDatamVPa21,
                tBPovDatamVPa22,
                tBPovDatamVPa23,
                tBPovDatamVPa24,
                tBPovDatamVPa25,
                tBPovDatamVPa26,
                tBPovDatamVPa27
            };
            PovDatadB2 = new List<TextBox>
            {
                tBPovDatadB21,
                tBPovDatadB22,
                tBPovDatadB23,
                tBPovDatadB24,
                tBPovDatadB25,
                tBPovDatadB26,
                tBPovDatadB27
            };
            UpLhorLsaz = new List<TextBox>
            {
                tBUpLhorLsaz1,
                tBUpLhorLsaz2,
                tBUpLhorLsaz3,
                tBUpLhorLsaz4,
                tBUpLhorLsaz5,
                tBUpLhorLsaz6,
                tBUpLhorLsaz7
            };
            LhorLsaz = new List<TextBox>
            {
                tBLhorLsaz1,
                tBLhorLsaz2,
                tBLhorLsaz3,
                tBLhorLsaz4,
                tBLhorLsaz5,
                tBLhorLsaz6,
                tBLhorLsaz7
            };
            SumShum = new List<TextBox>
            {
                tBSumShum1,
                tBSumShum2,
                tBSumShum3,
                tBSumShum4,
                tBSumShum5,
                tBSumShum6,
                tBSumShum7
            };
            EiAfter = new List<TextBox>
            {
                tBEiAfter1,
                tBEiAfter2,
                tBEiAfter3,
                tBEiAfter4,
                tBEiAfter5,
                tBEiAfter6,
                tBEiAfter7
            };
            Ln = new List<TextBox>
            {
                tBLn1,
                tBLn2,
                tBLn3,
                tBLn4,
                tBLn5,
                tBLn6,
                tBLn7
            };
            D1 = new List<TextBox>
            {
                tBD1,
                tBD2,
                tBD3,
                tBD4,
                tBD5,
                tBD6,
                tBD7
            };
            A1 = new List<TextBox>
            {
                tBA1,
                tBA2,
                tBA3,
                tBA4,
                tBA5,
                tBA6,
                tBA7
            };
        }

        private List<TextBox> r = new List<TextBox>();
        private List<TextBox> Lsaz = new List<TextBox>();
        private List<TextBox> Lh = new List<TextBox>();
        private List<TextBox> Ltc = new List<TextBox>();
        private List<TextBox> Lsh = new List<TextBox>();
        private List<TextBox> Lc1 = new List<TextBox>();
        private List<TextBox> Lc2 = new List<TextBox>();
        private List<TextBox> Qi = new List<TextBox>();
        private List<TextBox> E = new List<TextBox>();
        private List<TextBox> q = new List<TextBox>();
        private List<TextBox> N = new List<TextBox>();
        private List<TextBox> R1 = new List<TextBox>();
        private TextBox[,] measurement = new TextBox[4, 7];
        private List<TextBox> p = new List<TextBox>();
        private List<TextBox> k = new List<TextBox>();
        private ShepotSim.ApplicationContext db;
        private DateTime StartTime;
        private List<TextBox> E2 = new List<TextBox>();
        private List<TextBox> NormMeas = new List<TextBox>();
        private List<TextBox> NormMeas2 = new List<TextBox>();
        private List<TextBox> NeedCorrect = new List<TextBox>();
        private List<TextBox> PovDatamVPa1 = new List<TextBox>();
        private List<TextBox> PovDatadB1 = new List<TextBox>();
        private List<TextBox> PovDatamVPa2 = new List<TextBox>();
        private List<TextBox> PovDatadB2 = new List<TextBox>();
        private List<TextBox> UpLhorLsaz = new List<TextBox>();
        private List<TextBox> LhorLsaz = new List<TextBox>();
        private List<TextBox> SumShum = new List<TextBox>();
        private List<TextBox> EiAfter = new List<TextBox>();
        private List<TextBox> Ln = new List<TextBox>();
        private List<TextBox> D1 = new List<TextBox>();
        private List<TextBox> A1 = new List<TextBox>();

        private double FunctionA(int f)
        {
            double result = 0.0;
            if (f <= 1000)
            {
                return 200.0 / Math.Pow(f, 0.43) - 0.37;
            }
            return 1.37 + 1000.0 / Math.Pow(f, 0.69);
        }

        private double FunctionK(double f)
        {
            double result = 0.0;
            if (f <= 400.0)
            {
                return 2.57 * Math.Pow(10.0, -8.0) * Math.Pow(f, 2.4);
            }
            return 1.0 - 1.074 * Math.Exp(-0.0001 * Math.Pow(f, 1.18));
        }

        private void IntelligibilityCalculation()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<IntelligibilityNorm> listIntelligibilityNorm = db.IntelligibilityNorms.ToList();
                IntelligibilityNorm norm = listIntelligibilityNorm.Find((IntelligibilityNorm m) => m.Channel.Equals(comboBoxChannelCheckPoint.Text));
                double[,] octav = new double[3, 7]
                {
                    {
                        87.5,
                        175.0,
                        350.0,
                        700.0,
                        1400.0,
                        2800.0,
                        5600.0
                    },
                    {
                        175.0,
                        350.0,
                        700.0,
                        1400.0,
                        2800.0,
                        5600.0,
                        11200.0
                    },
                    {
                        125.0,
                        250.0,
                        500.0,
                        1000.0,
                        2000.0,
                        4000.0,
                        8000.0
                    }
                };
                List<double> listr = new List<double>();
                bool saz = false;
                if (Lsaz[0].Text != "")
                {
                    saz = true;
                }
                for (int i = 0; i < Ltc.Count; i++)
                {
                    double tc = Convert.ToDouble(Ltc[i].Text);
                    double sh = Convert.ToDouble(Lsh[i].Text);
                    double h2 = 0.0;
                    double uplhorlsaz = 0.0;
                    h2 = ((!saz) ? Convert.ToDouble(Lh[i].Text) : Convert.ToDouble(Lsaz[i].Text));
                    LhorLsaz[i].Text = (!saz) ? Lh[i].Text : Lsaz[i].Text;
                    SumShum[i].Text = (!saz) ? Lh[i].Text : Lsaz[i].Text;
                    UpLhorLsaz[i].Text = Convert.ToString(uplhorlsaz);
                    double c = 10.0 * Math.Log10(Math.Pow(10.0, 0.1 * sh) - Math.Pow(10.0, 0.1 * h2));
                    int f2 = 0;
                    f2 = ((Ltc.Count != 7) ? Convert.ToInt32(octav[2, i + 1]) : Convert.ToInt32(octav[2, i]));
                    double Ln2 = 0.0;
                    Ln2 = ((comboBoxSpeechLevel.SelectedIndex != 0) ? GetLn(84, f2) : GetLn(70, f2));
                    double D = tc - Ln2;
                    double e1 = c - h2 - D;
                    double A = FunctionA(f2);
                    double qi = e1 - A;
                    double pi2 = 0.0;
                    pi2 = ((!(qi <= 0.0)) ? (1.0 - (0.78 + 5.46 * Math.Exp(-0.0043 * Math.Pow(27.3 - Math.Abs(qi), 2.0))) / (1.0 + Math.Pow(10.0, 0.1 * Math.Abs(qi)))) : ((0.78 + 5.46 * Math.Exp(-0.0043 * Math.Pow(27.3 - Math.Abs(qi), 2.0))) / (1.0 + Math.Pow(10.0, 0.1 * Math.Abs(qi)))));
                    double ki2 = 0.0;
                    ki2 = ((Ltc.Count != 7) ? (FunctionK(octav[1, i + 1]) - FunctionK(octav[0, i + 1])) : (FunctionK(octav[1, i]) - FunctionK(octav[0, i])));
                    double ri = pi2 * ki2;
                    listr.Add(ri);
                    Lc2[i].Text = Convert.ToString(Math.Round(c, 2));
                    E[i].Text = Convert.ToString(Math.Round(e1, 2));
                    E2[i].Text = Convert.ToString(Math.Round(e1, 2));
                    EiAfter[i].Text = Convert.ToString(Math.Round(e1, 2));
                    q[i].Text = Convert.ToString(Math.Round(qi, 2));
                    p[i].Text = Convert.ToString(Math.Round(pi2, 4));
                    k[i].Text = Convert.ToString(Math.Round(ki2, 4));
                    r[i].Text = Convert.ToString(Math.Round(ri, 4));
                    Ln[i].Text = Convert.ToString(Ln2);
                    D1[i].Text = Convert.ToString(Math.Round(D, 4));
                    A1[i].Text = Convert.ToString(Math.Round(A, 4));
                }
                double R = 0.0;
                foreach (double ri2 in listr)
                {
                    R += ri2;
                }
                double W2 = 0.0;
                W2 = ((!(R < 0.15)) ? (1.0 - Math.Exp(-11.0 * R / (1.0 + 0.7 * R))) : (1.54 * Math.Pow(R, 0.25) * (1.0 - Math.Exp(-11.0 * R))));
                tBW.Text = Convert.ToString(Math.Round(W2, 4));
                tBWCopy.Text = Convert.ToString(Math.Round(W2, 4));
                tBN.Text = Convert.ToString(norm.NormValue);
                if (W2 <= norm.NormValue)
                {
                    tBR.Text = "да";
                }
                else
                {
                    tBR.Text = "нет";
                }
            }
        }
        private double GetLn(int SpeechLevel, int f)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<NormalizedSoundLevel> listNormalizedSoundLevel = db.NormalizedSoundLevels.ToList();
                IEnumerable<NormalizedSoundLevel> normalizedSoundLevels = listNormalizedSoundLevel.Where((NormalizedSoundLevel m) => m.SpeechLevel.Equals(SpeechLevel));
                List<NormalizedSoundLevel> normLev = new List<NormalizedSoundLevel>();
                foreach (NormalizedSoundLevel nlev in normalizedSoundLevels)
                {
                    normLev.Add(nlev);
                }
                NormalizedSoundLevel norma = normLev.Find((NormalizedSoundLevel m) => m.f.Equals(f));
                return norma.NormValue;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ShepotSim.ApplicationContext();
            CleanPageCheckPoint();
            GetStructure();
            tmrClock.Enabled = true;
            StartTime = DateTime.Now;
            cbSAZavailability.Enabled = false;
        }

        private void LoadCheckPoint(int id)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<CheckPoint> listCheckPoint = db.CheckPoints.ToList();
                List<User> listUser = db.Users.ToList();
                CheckPoint checkPoint = listCheckPoint.Find((CheckPoint m) => m.CheckPointId.Equals(id));
                User user = listUser.Find((User m) => m.UserID.Equals(checkPoint.UserID));
                tBCheckPointId.Text = Convert.ToString(checkPoint.CheckPointId);
                textBoxCheckPointName.Text = checkPoint.CheckPointName;
                tBDescription.Text = checkPoint.Description;
                if (checkPoint.SpeechLevel == 70)
                {
                    comboBoxSpeechLevel.SelectedIndex = 0;
                }
                else
                {
                    comboBoxSpeechLevel.SelectedIndex = 1;
                }
                comboBoxChannelCheckPoint.Text = checkPoint.Channel;
                cbSZY.Checked = checkPoint.SZY;
                lblElapsed.Text = checkPoint.ElapsedTime;
                tBSurname.Text = user.Surname;
                tBName.Text = user.Name;
                tBPatronymic.Text = user.Patronymic;
                dateTimeDateOfCreate.Text = checkPoint.DateOfCreate;
                tBStudyGroup.Text = user.StudyGroup;
                if (checkPoint.PovData1 == true)
                {
                    for (int i = 0; i < PovDatadB1.Count; i++)
                    {
                        double checkvalue = Convert.ToDouble(PovDatamVPa1[i].Text);
                        double N = Math.Round(20 * Math.Log10(checkvalue / 1000), 1);
                        PovDatadB1[i].Text = Convert.ToString(N);
                        PovDatadB1[i].BackColor = Color.LimeGreen;
                    }
                    label114.Text = "Выполнено успешно";
                    label114.BackColor = Color.LimeGreen;
                }
                if (checkPoint.PovData2 == true)
                {
                    for (int i = 0; i < PovDatamVPa2.Count; i++)
                    {
                        double checkvalue = Convert.ToDouble(PovDatadB2[i].Text);
                        double E = Math.Round(1000 * Math.Pow(10, (checkvalue / 20)), 2);
                        PovDatamVPa2[i].Text = Convert.ToString(E);
                        PovDatamVPa2[i].BackColor = Color.LimeGreen;
                    }
                    label115.Text = "Выполнено успешно";
                    label115.BackColor = Color.LimeGreen;
                }
                List<Measurement> listMeasurement = db.Measurements.ToList();
                IEnumerable<Measurement> listmeasurement = listMeasurement.Where((Measurement m) => m.CheckPointId.Equals(id));
                comboBoxInterceptionPlace.Text = checkPoint.InterceptionPlace;
                List<Measurement> meas = new List<Measurement>();
                foreach (Measurement measur in listmeasurement)
                {
                    meas.Add(measur);
                }
                SproofingNorm sprnorm = new SproofingNorm();
                if (meas.Count != 0)
                {
                    if (meas[0].Qi != 0.0)
                    {
                        List<SproofingNorm> listSproofingNorm = db.SproofingNorms.ToList();
                        IEnumerable<SproofingNorm> listsproofingNorm = listSproofingNorm.Where((SproofingNorm m) => m.SZY.Equals(cbSZY.Checked));
                        List<SproofingNorm> sproofingNorms = new List<SproofingNorm>();
                        foreach (SproofingNorm spr in listsproofingNorm)
                        {
                            sproofingNorms.Add(spr);
                        }
                        sprnorm = sproofingNorms.Find((SproofingNorm m) => m.Conditions.Equals(checkPoint.InterceptionPlace));
                    }
                    for (int i = 0; i < meas.Count; i++)
                    {
                        Ltc[i].Text = Convert.ToString(meas[i].Ltc);
                        Lsh[i].Text = Convert.ToString(meas[i].Lsh);
                        Lh[i].Text = Convert.ToString(meas[i].Lh);
                        if (meas[i].Lsaz != 0.0)
                        {
                            Lsaz[i].Text = Convert.ToString(meas[i].Lsaz);
                        }
                        if (meas[i].LhOrLsazChange != 0.0)
                        {
                            SumShum[i].Text = Convert.ToString(meas[i].LhOrLsazChange);
                            label1177.Text = "Выполнено успешно";
                            label1177.BackColor = Color.LimeGreen;
                        }
                        if (meas[i].Qi != 0.0)
                        {
                            Lc1[i].Text = Convert.ToString(meas[i].Lc);
                            Qi[i].Text = Convert.ToString(meas[i].Qi);
                            N[i].Text = Convert.ToString(sprnorm.NormValue);
                            if (meas[i].Qi >= sprnorm.NormValue)
                            {
                                R1[i].Text = "да";
                                R1[i].BackColor = Color.LimeGreen;
                            }
                            else
                            {
                                R1[i].Text = "нет";
                                R1[i].BackColor = Color.Red;
                            }
                        }
                        if (meas[i].E != 0.0)
                        {
                            Lc2[i].Text = Convert.ToString(meas[i].Lc);
                            Ln[i].Text = Convert.ToString(meas[i].Ln);
                            D1[i].Text = Convert.ToString(meas[i].D);
                            E[i].Text = Convert.ToString(meas[i].E);
                            A1[i].Text = Convert.ToString(meas[i].A);
                            q[i].Text = Convert.ToString(meas[i].q);
                            p[i].Text = Convert.ToString(meas[i].p);
                            k[i].Text = Convert.ToString(meas[i].k);
                            r[i].Text = Convert.ToString(meas[i].r);
                        }
                    }
                }
                if (checkPoint.W != 0.0)
                {
                    tBW.Text = Convert.ToString(checkPoint.W);
                    tBWCopy.Text = Convert.ToString(checkPoint.W);
                    List<IntelligibilityNorm> listIntelligibilityNorm = db.IntelligibilityNorms.ToList();
                    IntelligibilityNorm intnorm = listIntelligibilityNorm.Find((IntelligibilityNorm m) => m.Channel.Equals(checkPoint.Channel));
                    tBN.Text = Convert.ToString(intnorm.NormValue);
                    if (Convert.ToDouble(tBW.Text) <= Convert.ToDouble(tBN.Text))
                    {
                        tBR.Text = "да";
                        tBR.BackColor = Color.LimeGreen;
                    }
                    else
                    {
                        tBR.Text = "нет";
                        tBR.BackColor = Color.Red;
                    }
                }
            }
        }

        public void GetStructure()
        {
            treeViewStructure.Nodes.Clear();
            db = new ShepotSim.ApplicationContext();
            List<User> listUser = db.Users.ToList();
            List<CheckPoint> listCheckPoint = db.CheckPoints.ToList();
            IEnumerable<User> listusr = listUser.Where((User m) => m.UserID.Equals(Data.Value));
            int i = -1;
            foreach (User usr in listusr)
            {
                if (usr.AdminPanel == true)
                {
                    Text = "СОЗ Шепот (учебный стенд)" + " - Вы авторизованы как " + usr.Surname + " " + usr.Name.Substring(0, 1) + ". " + usr.Patronymic.Substring(0, 1) + "., гр. " + usr.StudyGroup;
                    int j = -1;
                    foreach (User usr1 in listUser)
                    {
                        j++;
                        TreeNode treeNode = new TreeNode("гр. " + usr1.StudyGroup);
                        treeViewStructure.Nodes.Add(treeNode);
                        IEnumerable<User> listUser2 = listUser.Where((User m) => m.UserID.Equals(usr1.UserID));
                        int z = -1;
                        foreach (User usr2 in listUser2)
                        {
                            z++;
                            TreeNode subtreeNode = new TreeNode(usr2.Surname + " " + usr2.Name.Substring(0, 1) + ". " + usr2.Patronymic.Substring(0, 1));
                            treeViewStructure.Nodes[j].Nodes.Add(subtreeNode);
                            IEnumerable<CheckPoint> listchp = listCheckPoint.Where((CheckPoint m) => m.UserID.Equals(usr2.UserID));
                            foreach (CheckPoint chp in listchp)
                            {
                                TreeNode subsubtreeNode = new TreeNode(chp.CheckPointName);
                                subsubtreeNode.Tag = chp.CheckPointId;
                                treeViewStructure.Nodes[j].Nodes[z].Nodes.Add(subsubtreeNode);
                            }
                        }
                    }
                }
                else
                {
                    Text = "СОЗ Шепот (учебный стенд)" + " - Вы авторизованы как " + usr.Surname + " " + usr.Name.Substring(0, 1) + ". " + usr.Patronymic.Substring(0, 1) + "., гр. " + usr.StudyGroup;
                    i++;
                    TreeNode subtreeNode = new TreeNode(usr.Surname + " " + usr.Name.Substring(0, 1) + ". " + usr.Patronymic.Substring(0, 1) + "., гр. " + usr.StudyGroup);
                    treeViewStructure.Nodes.Add(subtreeNode);
                    IEnumerable<CheckPoint> listchp = listCheckPoint.Where((CheckPoint m) => m.UserID.Equals(usr.UserID));
                    foreach (CheckPoint chp in listchp)
                    {
                        TreeNode subsubtreeNode = new TreeNode(chp.CheckPointName);
                        subsubtreeNode.Tag = chp.CheckPointId;
                        treeViewStructure.Nodes[i].Nodes.Add(subsubtreeNode);
                    }
                }
            }
        }

        private void treeViewStructure_DoubleClick(object sender, EventArgs e)
        {
            CleanPageCheckPoint();
            if (treeViewStructure.SelectedNode != null)
            {
                if (treeViewStructure.SelectedNode.Tag != null)
                {
                    LoadCheckPoint(Convert.ToInt32(treeViewStructure.SelectedNode.Tag));
                }
            }
            tmrClock.Enabled = false;
            if (tBLsh1.Text != "" & tBLh1.Text != "" & tBLtc1.Text != "")
            {
                FillGistogram();
            }
        }

        private void CleanPageCheckPoint()
        {
            tBCheckPointId.Text = "";
            textBoxCheckPointName.Text = "";
            tBDescription.Text = "";
            comboBoxSpeechLevel.SelectedIndex = 0;
            comboBoxSpeechLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxChannelCheckPoint.Items.Clear();
            cbSZY.Checked = false;
            cbSAZ.Checked = false;
            cbSAZavailability.Checked = false;
            lblElapsed.Text = "00:00:00.0";
            tBSurname.Text = "";
            tBName.Text = "";
            tBPatronymic.Text = "";
            dateTimeDateOfCreate.Text = "";
            tBStudyGroup.Text = "";
            comboBoxGFData.Items.Clear();
            comboBoxConstructionThickness.Items.Clear();
            comboBoxGFDSpeechLevel.Items.Clear();
            tBGFDId.Text = "";
            cbSZYforGFD.Checked = false;
            cbSAZ.Enabled = false;
            label114.Text = "";
            label115.Text = "";
            label112.Text = "";
            label1177.Text = "";
            label1177.ForeColor = Color.White;
            labelwarn.Text = "";
            label111.Enabled = false;
            tBSAZUp.Enabled = false;
            tBSAZUp.Text = "";
            btnUpDwSAZ.Enabled = false;
            LoadGFDataConstruction();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();
            chart2.Series[3].Points.Clear();
            foreach (Control tB2 in groupBoxShoroh.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
            foreach (Control PovDatamVPa2 in groupBoxPovData.Controls)
            {
                if (PovDatamVPa2 is TextBox)
                {
                    PovDatamVPa2.Text = "";
                    PovDatamVPa2.BackColor = Color.White;
                }
            }
            foreach (Control PovDatadB1 in groupBoxPovData.Controls)
            {
                if (PovDatadB1 is TextBox)
                {
                    PovDatadB1.Text = "";
                    PovDatadB1.BackColor = Color.White;
                }
            }
            foreach (Control tB2 in groupBoxNormValue.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
            LoadPovData();
            List<IntelligibilityNorm> listIntelligibilityNorm = db.IntelligibilityNorms.ToList();
            foreach (IntelligibilityNorm norm in listIntelligibilityNorm)
            {
                comboBoxChannelCheckPoint.Items.Add(norm.Channel);
            }
            comboBoxChannelCheckPoint.SelectedIndex = 0;
            comboBoxChannelCheckPoint.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Control tB3 in groupBoxMeasurementResults.Controls)
            {
                if (tB3 is TextBox)
                {
                    tB3.Text = "";
                    tB3.BackColor = Color.White;
                }
            }
            comboBoxInterceptionPlace.Items.Clear();
            List<SproofingNorm> listSproofingNorm = db.SproofingNorms.ToList();
            foreach (SproofingNorm norm2 in listSproofingNorm)
            {
                if (!comboBoxInterceptionPlace.Items.Contains(norm2.Conditions))
                {
                    comboBoxInterceptionPlace.Items.Add(norm2.Conditions);
                }
            }
            comboBoxInterceptionPlace.SelectedIndex = 0;
            comboBoxInterceptionPlace.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Control tB2 in groupBoxSoundproofing.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
            foreach (Control tB in groupBoxIntelligibility.Controls)
            {
                if (tB is TextBox)
                {
                    tB.Text = "";
                    tB.BackColor = Color.White;
                }
            }
            measurement = new TextBox[4, 7]
            {
                {
                tBLtc1,
                tBLtc2,
                tBLtc3,
                tBLtc4,
                tBLtc5,
                tBLtc6,
                tBLtc7
            },
            {
                tBLsh1,
                tBLsh2,
                tBLsh3,
                tBLsh4,
                tBLsh5,
                tBLsh6,
                tBLsh7
            },
            {
                tBLh1,
                tBLh2,
                tBLh3,
                tBLh4,
                tBLh5,
                tBLh6,
                tBLh7
            },
            {
                tBLsaz1,
                tBLsaz2,
                tBLsaz3,
                tBLsaz4,
                tBLsaz5,
                tBLsaz6,
                tBLsaz7
            }
            };
        }

        private void btnSavecheckPoint_Click(object sender, EventArgs e)
        {
            foreach (Control tB in groupBoxMeasurementResults.Controls)
            {
                if (tB is TextBox)
                {
                    tB.BackColor = Color.White;
                }
            }
            tmrClock.Enabled = false;
            SaveCheckPoint();
            GetStructure();
        }

        private void SaveCheckPoint()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                bool SaveSuccess = true;
                List<CheckPoint> listCheckPoint = db.CheckPoints.ToList();
                bool exist = false;
                foreach (CheckPoint chp in listCheckPoint)
                {
                    if (Convert.ToString(chp.CheckPointId) == tBCheckPointId.Text)
                    {
                        exist = true;
                    }
                }
                if (!exist)
                {
                    CheckPoint newCheckPoint = new CheckPoint();
                    if (listCheckPoint.Count != 0)
                    {
                        newCheckPoint.CheckPointId = listCheckPoint.Last().CheckPointId + 1;
                    }
                    else
                    {
                        newCheckPoint.CheckPointId = 1;
                    }
                    if (label114.Text == "Выполнено успешно")
                    {
                        newCheckPoint.PovData1 = true;
                    }
                    if (label115.Text == "Выполнено успешно")
                    {
                        newCheckPoint.PovData2 = true;
                    }
                    newCheckPoint.CheckPointName = textBoxCheckPointName.Text;
                    newCheckPoint.Description = tBDescription.Text;
                    newCheckPoint.Channel = comboBoxChannelCheckPoint.Text;
                    newCheckPoint.SZY = cbSZY.Checked;
                    newCheckPoint.ElapsedTime = lblElapsed.Text;
                    newCheckPoint.DateOfCreate = dateTimeDateOfCreate.Text;
                    newCheckPoint.UserID = Data.Value;
                    if (comboBoxSpeechLevel.SelectedIndex == 0)
                    {
                        newCheckPoint.SpeechLevel = 70;
                    }
                    else
                    {
                        newCheckPoint.SpeechLevel = 84;
                    }
                    newCheckPoint.InterceptionPlace = comboBoxInterceptionPlace.Text;
                    if (tBW.Text != "")
                    {
                        double R2 = 0.0;
                        for (int i5 = 0; i5 < r.Count; i5++)
                        {
                            R2 += Convert.ToDouble(r[i5].Text);
                        }
                        newCheckPoint.R = R2;
                        newCheckPoint.W = Convert.ToDouble(tBW.Text);
                    }
                    else
                    {
                        newCheckPoint.R = 0.0;
                        newCheckPoint.W = 0.0;
                    }
                    db.CheckPoints.Add(newCheckPoint);
                    db.SaveChanges();
                    tBCheckPointId.Text = Convert.ToString(newCheckPoint.CheckPointId);
                    bool isEmpty2 = true;
                    foreach (Control tB8 in groupBoxMeasurementResults.Controls)
                    {
                        if (tB8 is TextBox && tB8.Text != "")
                        {
                            isEmpty2 = false;
                        }
                    }
                    if (!isEmpty2)
                    {
                        bool notAllData2 = false;
                        foreach (TextBox tB7 in Ltc)
                        {
                            if (tB7.Text == "")
                            {
                                notAllData2 = true;
                                tB7.BackColor = Color.Red;
                            }
                        }
                        foreach (TextBox tB6 in Lsh)
                        {
                            if (tB6.Text == "")
                            {
                                notAllData2 = true;
                                tB6.BackColor = Color.Red;
                            }
                        }
                        foreach (TextBox tB5 in Lh)
                        {
                            if (tB5.Text == "")
                            {
                                notAllData2 = true;
                                tB5.BackColor = Color.Red;
                            }
                        }
                        if (notAllData2)
                        {
                            SaveSuccess = false;
                        }
                        else
                        {
                            for (int i4 = 0; i4 < 4; i4++)
                            {
                                for (int j2 = 0; j2 < 7; j2++)
                                {
                                    if (measurement[i4, j2].Text != "")
                                    {
                                        try
                                        {
                                            double ch2 = Convert.ToDouble(measurement[i4, j2].Text);
                                        }
                                        catch
                                        {
                                            SaveSuccess = false;
                                            measurement[i4, j2].BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                            if (SaveSuccess)
                            {
                                SaveSuccess = false;
                                for (int i3 = 0; i3 < Ltc.Count; i3++)
                                {
                                    double tc2 = Convert.ToDouble(Ltc[i3].Text);
                                    double sh2 = Convert.ToDouble(Lsh[i3].Text);
                                    double h2 = Convert.ToDouble(Lh[i3].Text);
                                    if (tc2 > sh2 && sh2 > h2)
                                    {
                                        SaveSuccess = true;
                                        continue;
                                    }
                                    Ltc[i3].BackColor = Color.Red;
                                    Lsh[i3].BackColor = Color.Red;
                                    Lh[i3].BackColor = Color.Red;
                                }
                            }
                            if (SaveSuccess)
                            {
                                for (int i2 = 0; i2 < Ltc.Count; i2++)
                                {
                                    List<Measurement> listMeasurement2 = db.Measurements.ToList();
                                    Measurement newMeasurement2 = new Measurement();
                                    if (listMeasurement2.Count > 0)
                                    {
                                        newMeasurement2.MeasurementId = listMeasurement2.Last().MeasurementId + 1;
                                    }
                                    else
                                    {
                                        newMeasurement2.MeasurementId = 1;
                                    }
                                    newMeasurement2.CheckPointId = Convert.ToInt32(tBCheckPointId.Text);
                                    switch (i2)
                                    {
                                        case 0:
                                            newMeasurement2.f = 125;
                                            break;
                                        case 1:
                                            newMeasurement2.f = 250;
                                            break;
                                        case 2:
                                            newMeasurement2.f = 500;
                                            break;
                                        case 3:
                                            newMeasurement2.f = 1000;
                                            break;
                                        case 4:
                                            newMeasurement2.f = 2000;
                                            break;
                                        case 5:
                                            newMeasurement2.f = 4000;
                                            break;
                                        case 6:
                                            newMeasurement2.f = 8000;
                                            break;
                                    }
                                    newMeasurement2.Ltc = Convert.ToDouble(Ltc[i2].Text);
                                    newMeasurement2.Lsh = Convert.ToDouble(Lsh[i2].Text);
                                    newMeasurement2.Lh = Convert.ToDouble(Lh[i2].Text);
                                    if (Lsaz[i2].Text != "")
                                    {
                                        newMeasurement2.Lsaz = Convert.ToDouble(Lsaz[i2].Text);
                                    }
                                    else
                                    {
                                        newMeasurement2.Lsaz = 0.0;
                                    }
                                    if (Qi[i2].Text != "")
                                    {
                                        newMeasurement2.Lc = Convert.ToDouble(Lc1[i2].Text);
                                        newMeasurement2.Qi = Convert.ToDouble(Qi[i2].Text);
                                    }
                                    else
                                    {
                                        newMeasurement2.Lc = 0.0;
                                        newMeasurement2.Qi = 0.0;
                                    }
                                    if (SumShum[i2].Text != "" & label1177.Text == "Выполнено успешно")
                                    {
                                        newMeasurement2.LhOrLsazChange = Convert.ToDouble(SumShum[i2].Text);
                                    }
                                    if (E[i2].Text != "")
                                    {
                                        newMeasurement2.Lc = Convert.ToDouble(Lc2[i2].Text);
                                        if (comboBoxSpeechLevel.SelectedIndex == 0)
                                        {
                                            newMeasurement2.Ln = GetLn(70, newMeasurement2.f);
                                        }
                                        else
                                        {
                                            newMeasurement2.Ln = GetLn(84, newMeasurement2.f);
                                        }
                                        newMeasurement2.D = newMeasurement2.Ltc - newMeasurement2.Ln;
                                        newMeasurement2.E = Convert.ToDouble(E[i2].Text);
                                        newMeasurement2.A = FunctionA(newMeasurement2.f);
                                        newMeasurement2.q = Convert.ToDouble(q[i2].Text);
                                        newMeasurement2.p = Convert.ToDouble(p[i2].Text);
                                        newMeasurement2.k = Convert.ToDouble(this.k[i2].Text);
                                        newMeasurement2.r = Convert.ToDouble(r[i2].Text);
                                    }
                                    else
                                    {
                                        if (Qi[i2].Text == "")
                                        {
                                            newMeasurement2.Lc = 0.0;
                                        }
                                        newMeasurement2.Ln = 0.0;
                                        newMeasurement2.D = 0.0;
                                        newMeasurement2.E = 0.0;
                                        newMeasurement2.A = 0.0;
                                        newMeasurement2.q = 0.0;
                                        newMeasurement2.p = 0.0;
                                        newMeasurement2.k = 0.0;
                                        newMeasurement2.r = 0.0;
                                    }
                                    db.Measurements.Add(newMeasurement2);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
                else
                {
                    CheckPoint checkPoint = listCheckPoint.Find((CheckPoint m) => m.CheckPointId.Equals(Convert.ToInt32(tBCheckPointId.Text)));
                    checkPoint.CheckPointName = textBoxCheckPointName.Text;
                    checkPoint.Description = tBDescription.Text;
                    checkPoint.Channel = comboBoxChannelCheckPoint.Text;
                    checkPoint.SZY = cbSZY.Checked;
                    checkPoint.ElapsedTime = lblElapsed.Text;
                    checkPoint.DateOfCreate = dateTimeDateOfCreate.Text;
                    checkPoint.UserID = Data.Value;
                    if (comboBoxSpeechLevel.SelectedIndex == 0)
                    {
                        checkPoint.SpeechLevel = 70;
                    }
                    else
                    {
                        checkPoint.SpeechLevel = 84;
                    }
                    checkPoint.InterceptionPlace = comboBoxInterceptionPlace.Text;
                    if (tBW.Text != "")
                    {
                        double R = 0.0;
                        for (int n = 0; n < r.Count; n++)
                        {
                            R += Convert.ToDouble(r[n].Text);
                        }
                        checkPoint.R = R;
                        checkPoint.W = Convert.ToDouble(tBW.Text);
                    }
                    else
                    {
                        checkPoint.R = 0.0;
                        checkPoint.W = 0.0;
                    }
                    db.Entry(checkPoint).State = EntityState.Modified;
                    db.SaveChanges();
                    tBCheckPointId.Text = Convert.ToString(checkPoint.CheckPointId);
                    bool isEmpty = true;
                    foreach (Control tB4 in groupBoxMeasurementResults.Controls)
                    {
                        if (tB4 is TextBox && tB4.Text != "")
                        {
                            isEmpty = false;
                        }
                    }
                    if (!isEmpty)
                    {
                        bool notAllData = false;
                        foreach (TextBox tB3 in Ltc)
                        {
                            if (tB3.Text == "")
                            {
                                notAllData = true;
                                tB3.BackColor = Color.Red;
                            }
                        }
                        foreach (TextBox tB2 in Lsh)
                        {
                            if (tB2.Text == "")
                            {
                                notAllData = true;
                                tB2.BackColor = Color.Red;
                            }
                        }
                        foreach (TextBox tB in Lh)
                        {
                            if (tB.Text == "")
                            {
                                notAllData = true;
                                tB.BackColor = Color.Red;
                            }
                        }
                        if (notAllData)
                        {
                            SaveSuccess = false;
                        }
                        else
                        {
                            for (int l = 0; l < 4; l++)
                            {
                                for (int i = 0; i < 7; i++)
                                {
                                    if (measurement[l, i].Text != "")
                                    {
                                        try
                                        {
                                            double ch = Convert.ToDouble(measurement[l, i].Text);
                                        }
                                        catch
                                        {
                                            SaveSuccess = false;
                                            measurement[l, i].BackColor = Color.Red;
                                        }
                                    }
                                }
                            }
                            if (SaveSuccess)
                            {
                                SaveSuccess = false;
                                for (int k = 0; k < Ltc.Count; k++)
                                {
                                    double tc = Convert.ToDouble(Ltc[k].Text);
                                    double sh = Convert.ToDouble(Lsh[k].Text);
                                    double h = Convert.ToDouble(Lh[k].Text);
                                    if (tc > sh && sh > h)
                                    {
                                        SaveSuccess = true;
                                        continue;
                                    }
                                    Ltc[k].BackColor = Color.Red;
                                    Lsh[k].BackColor = Color.Red;
                                    Lh[k].BackColor = Color.Red;
                                }
                            }
                            if (SaveSuccess)
                            {
                                List<Measurement> listmeasurement = db.Measurements.ToList();
                                IEnumerable<Measurement> Measurements = listmeasurement.Where((Measurement m) => m.CheckPointId.Equals(checkPoint.CheckPointId));
                                if (Measurements.Count() != 0)
                                {
                                    foreach (Measurement meas in Measurements)
                                    {
                                        db.Measurements.Remove(meas);
                                    }
                                    db.SaveChanges();
                                }
                                for (int j = 0; j < Ltc.Count; j++)
                                {
                                    List<Measurement> listMeasurement = db.Measurements.ToList();
                                    Measurement newMeasurement = new Measurement();
                                    if (listMeasurement.Count != 0)
                                    {
                                        newMeasurement.MeasurementId = listMeasurement.Last().MeasurementId + 1;
                                    }
                                    else
                                    {
                                        newMeasurement.MeasurementId = 1;
                                    }
                                    newMeasurement.CheckPointId = Convert.ToInt32(tBCheckPointId.Text);
                                    switch (j)
                                    {
                                        case 0:
                                            newMeasurement.f = 125;
                                            break;
                                        case 1:
                                            newMeasurement.f = 250;
                                            break;
                                        case 2:
                                            newMeasurement.f = 500;
                                            break;
                                        case 3:
                                            newMeasurement.f = 1000;
                                            break;
                                        case 4:
                                            newMeasurement.f = 2000;
                                            break;
                                        case 5:
                                            newMeasurement.f = 4000;
                                            break;
                                        case 6:
                                            newMeasurement.f = 8000;
                                            break;
                                    }
                                    newMeasurement.Ltc = Convert.ToDouble(Ltc[j].Text);
                                    newMeasurement.Lsh = Convert.ToDouble(Lsh[j].Text);
                                    newMeasurement.Lh = Convert.ToDouble(Lh[j].Text);
                                    if (Lsaz[j].Text != "")
                                    {
                                        newMeasurement.Lsaz = Convert.ToDouble(Lsaz[j].Text);
                                    }
                                    else
                                    {
                                        newMeasurement.Lsaz = 0.0;
                                    }
                                    if (Qi[j].Text != "")
                                    {
                                        newMeasurement.Lc = Convert.ToDouble(Lc1[j].Text);
                                        newMeasurement.Qi = Convert.ToDouble(Qi[j].Text);
                                    }
                                    else
                                    {
                                        newMeasurement.Lc = 0.0;
                                        newMeasurement.Qi = 0.0;
                                    }
                                    if (E[j].Text != "")
                                    {
                                        newMeasurement.Lc = Convert.ToDouble(Lc2[j].Text);
                                        if (comboBoxSpeechLevel.SelectedIndex == 0)
                                        {
                                            newMeasurement.Ln = GetLn(70, newMeasurement.f);
                                        }
                                        else
                                        {
                                            newMeasurement.Ln = GetLn(84, newMeasurement.f);
                                        }
                                        newMeasurement.D = newMeasurement.Ltc - newMeasurement.Ln;
                                        newMeasurement.E = Convert.ToDouble(E[j].Text);
                                        newMeasurement.A = FunctionA(newMeasurement.f);
                                        newMeasurement.q = Convert.ToDouble(q[j].Text);
                                        newMeasurement.p = Convert.ToDouble(p[j].Text);
                                        newMeasurement.k = Convert.ToDouble(this.k[j].Text);
                                        newMeasurement.r = Convert.ToDouble(r[j].Text);
                                    }
                                    else
                                    {
                                        if (Qi[j].Text == "")
                                        {
                                            newMeasurement.Lc = 0.0;
                                        }
                                        newMeasurement.Ln = 0.0;
                                        newMeasurement.D = 0.0;
                                        newMeasurement.E = 0.0;
                                        newMeasurement.A = 0.0;
                                        newMeasurement.q = 0.0;
                                        newMeasurement.p = 0.0;
                                        newMeasurement.k = 0.0;
                                        newMeasurement.r = 0.0;
                                    }
                                    db.Measurements.Add(newMeasurement);
                                    db.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAddCheckPoint_Click(object sender, EventArgs e)
        {
            CleanPageCheckPoint();
            tmrClock.Enabled = true;
            StartTime = DateTime.Now;
            chart2.Series[4].Points.Clear();
            if (treeViewStructure.SelectedNode != null)
            {
                if (treeViewStructure.SelectedNode.Tag != null)
                {
                    ForAddingCP();
                }
            }
        }

        private void ForAddingCP()
        {
            List<User> listUser = db.Users.ToList();
            IEnumerable<User> listusr = listUser.Where((User m) => m.UserID.Equals(Data.Value));
            foreach (User usr in listusr)
            {
                tBSurname.Text = usr.Surname;
                tBName.Text = usr.Name;
                tBPatronymic.Text = usr.Patronymic;
                tBStudyGroup.Text = usr.StudyGroup;
            }
        }

        private bool DataChecking()
        {
            bool result = true;
            bool notAllData = false;
            foreach (TextBox tB5 in Ltc)
            {
                if (tB5.Text == "")
                {
                    notAllData = true;
                    tB5.BackColor = Color.Red;
                }
            }
            foreach (TextBox tB4 in Lsh)
            {
                if (tB4.Text == "")
                {
                    notAllData = true;
                    tB4.BackColor = Color.Red;
                }
            }
            foreach (TextBox tB3 in Lh)
            {
                if (tB3.Text == "")
                {
                    notAllData = true;
                    tB3.BackColor = Color.Red;
                }
            }
            if (notAllData)
            {
                result = false;
            }
            else
            {
                for (int l = 0; l < 4; l++)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (measurement[l, i].Text != "")
                        {
                            try
                            {
                                double ch = Convert.ToDouble(measurement[l, i].Text);
                            }
                            catch
                            {
                                result = false;
                                measurement[l, i].BackColor = Color.Red;
                            }
                        }
                    }
                }
                if (result)
                {
                    result = false;
                    for (int k = 0; k < Ltc.Count; k++)
                    {
                        double tc = Convert.ToDouble(Ltc[k].Text);
                        double sh2 = Convert.ToDouble(Lsh[k].Text);
                        double h2 = Convert.ToDouble(Lh[k].Text);
                        if (tc > sh2 && sh2 > h2)
                        {
                            result = true;
                            continue;
                        }
                        Ltc[k].BackColor = Color.Red;
                        Lsh[k].BackColor = Color.Red;
                        Lh[k].BackColor = Color.Red;
                        label128.BackColor = Color.Red;
                        label128.ForeColor = Color.White;
                        label129.BackColor = Color.Red;
                        label129.ForeColor = Color.White;
                    }
                }
                if (result)
                {
                    bool emptySAZ = true;
                    notAllData = false;
                    foreach (TextBox tB2 in Lsaz)
                    {
                        if (tB2.Text != "")
                        {
                            emptySAZ = false;
                            break;
                        }
                    }
                    if (!emptySAZ)
                    {
                        foreach (TextBox tB in Lsaz)
                        {
                            if (tB.Text == "")
                            {
                                notAllData = true;
                                tB.BackColor = Color.Red;
                            }
                        }
                        if (notAllData)
                        {
                            result = false;
                        }
                        if (result)
                        {
                            result = false;
                            for (int j = 0; j < Ltc.Count; j++)
                            {
                                double sh = Convert.ToDouble(Lsh[j].Text);
                                double h = Convert.ToDouble(Lh[j].Text);
                                double saz = Convert.ToDouble(Lsaz[j].Text);
                                if (sh > saz && saz > h)
                                {
                                    result = true;
                                    continue;
                                }
                                Ltc[j].BackColor = Color.Red;
                                Lsh[j].BackColor = Color.Red;
                                Lh[j].BackColor = Color.Red;
                                Lsaz[j].BackColor = Color.Red;
                                label130.BackColor = Color.Red;
                                label130.ForeColor = Color.White;
                                label131.BackColor = Color.Red;
                                label131.ForeColor = Color.White;
                            }
                        }
                    }
                }
            }
            return result;
        }

        private void btnIntelligibility_Click(object sender, EventArgs e)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                foreach (Control tB2 in groupBoxMeasurementResults.Controls)
                {
                    if (tB2 is TextBox)
                    {
                        tB2.BackColor = Color.White;
                    }
                }
                foreach (Control tB in groupBoxIntelligibility.Controls)
                {
                    if (tB is TextBox)
                    {
                        tB.BackColor = Color.White;
                    }
                }
                label128.BackColor = Color.White;
                label128.ForeColor = Color.Black;
                label129.BackColor = Color.White;
                label129.ForeColor = Color.Black;
                label130.BackColor = Color.White;
                label130.ForeColor = Color.Black;
                label131.BackColor = Color.White;
                label131.ForeColor = Color.Black;
                if (DataChecking())
                {
                    IntelligibilityCalculation();
                    if (tBR.Text == "да")
                    {
                        tBR.BackColor = Color.LimeGreen;
                    }
                    else if (tBR.Text == "нет")
                    {
                        tBR.BackColor = Color.Red;
                    }
                }
                for (int i = 0; i < EiAfter.Count; i++)
                {
                    if (NormMeas2[i].Text != "" & EiAfter[i].Text != "")
                    {
                        if (Convert.ToInt32(NormMeas2[i].Text) < Convert.ToDouble(EiAfter[i].Text))
                        {
                            NeedCorrect[i].Text = "да";
                            NeedCorrect[i].BackColor = Color.Red;
                        }
                        else
                        {
                            NeedCorrect[i].Text = "нет";
                            NeedCorrect[i].BackColor = Color.LimeGreen;
                        }
                    }
                }
                ShorohCalculation();
                label1177.Text = "";
                label1177.BackColor = Color.White;
            }
        }

        private void SoundproofingCalculation()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<SproofingNorm> listSproofingNorm = db.SproofingNorms.ToList();
                IEnumerable<SproofingNorm> listsproofingNorm = listSproofingNorm.Where((SproofingNorm m) => m.SZY.Equals(cbSZY.Checked));
                List<SproofingNorm> sproofingNorms = new List<SproofingNorm>();
                foreach (SproofingNorm spr in listsproofingNorm)
                {
                    sproofingNorms.Add(spr);
                }
                SproofingNorm sprnorm = sproofingNorms.Find((SproofingNorm m) => m.Conditions.Equals(comboBoxInterceptionPlace.Text));
                for (int i = 0; i < Lsh.Count; i++)
                {
                    double tc = Convert.ToDouble(Ltc[i].Text);
                    double sh = Convert.ToDouble(Lsh[i].Text);
                    double h = Convert.ToDouble(Lh[i].Text);
                    double c = Math.Round(10.0 * Math.Log10(Math.Pow(10.0, 0.1 * sh) - Math.Pow(10.0, 0.1 * h)), 2);
                    double Q = tc - c;
                    Lc1[i].Text = Convert.ToString(c);
                    Qi[i].Text = Convert.ToString(Q);
                    N[i].Text = Convert.ToString(sprnorm.NormValue);
                    if (Q >= sprnorm.NormValue)
                    {
                        R1[i].Text = "да";
                    }
                    else
                    {
                        R1[i].Text = "нет";
                    }
                }
            }
        }

        private void btnSoundproofing_Click(object sender, EventArgs e)
        {
            foreach (Control tB3 in groupBoxMeasurementResults.Controls)
            {
                if (tB3 is TextBox)
                {
                    tB3.BackColor = Color.White;
                }
            }
            foreach (Control tB2 in groupBoxSoundproofing.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.BackColor = Color.White;
                }
            }
            label128.BackColor = Color.White;
            label128.ForeColor = Color.Black;
            label129.BackColor = Color.White;
            label129.ForeColor = Color.Black;
            label130.BackColor = Color.White;
            label130.ForeColor = Color.Black;
            label131.BackColor = Color.White;
            label131.ForeColor = Color.Black;
            if (DataChecking())
            {
                SoundproofingCalculation();
                foreach (TextBox tB in R1)
                {
                    if (tB.Text == "да")
                    {
                        tB.BackColor = Color.LimeGreen;
                    }
                    else if (tB.Text == "нет")
                    {
                        tB.BackColor = Color.Red;
                    }
                }
            }
        }

        private void comboBoxChannelCheckPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<IntelligibilityNorm> listIntelligibilityNorm = db.IntelligibilityNorms.ToList();
            IntelligibilityNorm norm = listIntelligibilityNorm.Find((IntelligibilityNorm m) => m.Channel.Equals(comboBoxChannelCheckPoint.Text));
            tBN.Text = Convert.ToString(norm.NormValue);
            if (tBW.Text != "")
            {
                if (Convert.ToDouble(tBW.Text) <= norm.NormValue)
                {
                    tBR.Text = "да";
                    tBR.BackColor = Color.LimeGreen;
                }
                else
                {
                    tBR.Text = "нет";
                    tBR.BackColor = Color.Red;
                }
            }
        }

        private void btnCheckPointDelete_Click(object sender, EventArgs e)
        {
            if (treeViewStructure.SelectedNode != null)
            {
                DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить эту КТ?", "Удаление объекта", MessageBoxButtons.YesNo);
                if (dialogResult != DialogResult.Yes)
                {
                    return;
                }
                int level = treeViewStructure.SelectedNode.Level;
                List<CheckPoint> listCheckPoint = db.CheckPoints.ToList();
                CheckPoint deleteCheckPoint = listCheckPoint.Find((CheckPoint m) => m.CheckPointId.Equals(Convert.ToInt32(treeViewStructure.SelectedNode.Tag)));
                List<Measurement> listMeasurement = db.Measurements.ToList();
                IEnumerable<Measurement> deletelistmeasur = listMeasurement.Where((Measurement m) => m.CheckPointId.Equals(deleteCheckPoint.CheckPointId));
                foreach (Measurement measur3 in deletelistmeasur)
                {
                    db.Measurements.Remove(measur3);
                    db.SaveChanges();
                }
                db.CheckPoints.Remove(deleteCheckPoint);
                db.SaveChanges();
            }
            GetStructure();
        }

        private void comboBoxInterceptionPlace_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<SproofingNorm> listSproofingNorm = db.SproofingNorms.ToList();
            IEnumerable<SproofingNorm> listsproofingNorm = listSproofingNorm.Where((SproofingNorm m) => m.SZY.Equals(cbSZY.Checked));
            List<SproofingNorm> sproofingNorms = new List<SproofingNorm>();
            foreach (SproofingNorm spr in listsproofingNorm)
            {
                sproofingNorms.Add(spr);
            }
            SproofingNorm sprnorm = sproofingNorms.Find((SproofingNorm m) => m.Conditions.Equals(comboBoxInterceptionPlace.Text));
            foreach (TextBox tB in N)
            {
                tB.Text = Convert.ToString(sprnorm.NormValue);
            }
            if (!(Qi[0].Text != ""))
            {
                return;
            }
            for (int i = 0; i < R1.Count; i++)
            {
                if (Convert.ToDouble(Qi[i].Text) >= sprnorm.NormValue)
                {
                    R1[i].Text = "да";
                    R1[i].BackColor = Color.LimeGreen;
                }
                else
                {
                    R1[i].Text = "нет";
                    R1[i].BackColor = Color.Red;
                }
            }
        }

        private void btnGetFirstData_Click(object sender, EventArgs e)
        {
            if (tBGFDId.Text != "" & comboBoxGFDSpeechLevel.Text != "" & comboBoxConstructionThickness.Text != "")
            {
                foreach (Control tB2 in groupBoxMeasurementResults.Controls)
                {
                    if (tB2 is TextBox)
                    {
                        tB2.Text = "";
                        tB2.BackColor = Color.White;
                    }
                }
                LoadGenerationFirstCheckPoint(Convert.ToInt32(tBGFDId.Text), /*Convert.ToInt32(comboBoxGFDSpeechLevel.Text),*/ comboBoxConstructionThickness.Text);
            }
        }

        private void LoadGFDataConstruction()
        {
            comboBoxGFData.Items.Clear();
            db = new ShepotSim.ApplicationContext();
            List<GenerationFirstCheckPoint> listGenerationFirstCheckPoint = db.GenerationFirstCheckPoints.ToList();
            foreach (GenerationFirstCheckPoint generationFirstCheckPoint in listGenerationFirstCheckPoint)
            {
                comboBoxGFData.Items.Add(generationFirstCheckPoint.GFCheckPointName);
            }
            comboBoxGFData.SelectedIndex = 0;
        }

        private void comboBoxGFData_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new ShepotSim.ApplicationContext();
            comboBoxGFDSpeechLevel.Items.Clear();
            comboBoxConstructionThickness.Items.Clear();
            cbSZYforGFD.Checked = false;
            cbSZY.Checked = false;
            cbSAZ.Checked = false;
            cbSAZavailability.Checked = false;
            cbSAZ.Enabled = false;
            label111.Enabled = false;
            tBSAZUp.Enabled = false;
            btnUpDwSAZ.Enabled = false;
            tBSAZUp.Text = "";
            label1177.Text = "";
            label1177.BackColor = Color.White;
            List<GenerationFirstCheckPoint> listGenerationFirstCheckPoint = db.GenerationFirstCheckPoints.ToList();
            foreach (GenerationFirstCheckPoint generationFirstCheckPoint in listGenerationFirstCheckPoint)
            {
                if (comboBoxGFData.Text == generationFirstCheckPoint.GFCheckPointName)
                {
                    tBGFDId.Text = Convert.ToString(generationFirstCheckPoint.GenerationFirstCheckPointId);
                    List<GenerationFirstMeasurement> listGenerationFirstMeasurement = db.GenerationFirstMeasurements.ToList();
                    foreach (GenerationFirstMeasurement generationFirstMeasurement in listGenerationFirstMeasurement)
                    {
                        if ((generationFirstCheckPoint.GenerationFirstCheckPointId == generationFirstMeasurement.GenerationFirstCheckPointId) & (!comboBoxConstructionThickness.Items.Contains(generationFirstMeasurement.ConstructionThickness)))
                        {
                            comboBoxConstructionThickness.Items.Add(generationFirstMeasurement.ConstructionThickness);
                        }
                    }
                }
            }
        }

        private void LoadGenerationFirstCheckPoint(int id, /*string measslid,*/ string measthinid)
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                List<GenerationFirstCheckPoint> listGenerationFirstCheckPoint = db.GenerationFirstCheckPoints.ToList();
                GenerationFirstCheckPoint gfcheckPoint = listGenerationFirstCheckPoint.Find((GenerationFirstCheckPoint m) => m.GenerationFirstCheckPointId.Equals(id));
                tBGFDId.Text = Convert.ToString(gfcheckPoint.GenerationFirstCheckPointId);
                List<GenerationFirstMeasurement> listGenerationFirstMeasurement = db.GenerationFirstMeasurements.ToList();
                IEnumerable<GenerationFirstMeasurement> listgenerationfirstmeasurement = listGenerationFirstMeasurement.Where((GenerationFirstMeasurement m) => m.GenerationFirstCheckPointId.Equals(id) /*& m.SpeechLevel.Equals(measslid)*/ & m.ConstructionThickness.Equals(measthinid));
                List<GenerationFirstMeasurement> meas = new List<GenerationFirstMeasurement>();
                foreach (GenerationFirstMeasurement measur in listgenerationfirstmeasurement)
                {
                    meas.Add(measur);
                }
                if (cbSZYforGFD.Checked == true)
                {
                    //int j = 0;
                    if (meas.Count != 0)
                    {
                        for (int i = 0; i < meas.Count; i++)
                        {
                            Random rnd = new Random();
                            int valueForAddLtc = rnd.Next(-2, 2);
                            int valueForAddLsh = rnd.Next(-2, 2);
                            int valueForAddLh = rnd.Next(-2, 2);
                            int valueForAddLsaz = rnd.Next(-2, 2);
                            double valueForAddDoubleLtc = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            double valueForAddDoubleLsh = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            double valueForAddDoubleLh = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            double valueForAddDoubleLsaz = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            Ltc[i].Text = Convert.ToString(meas[i].Ltc + valueForAddLtc + valueForAddDoubleLtc + 10);
                            Lsh[i].Text = Convert.ToString(meas[i].Lsh + valueForAddLsh + valueForAddDoubleLsh - 6);
                            Lh[i].Text = Convert.ToString(meas[i].Lh + valueForAddLh + valueForAddDoubleLh - 2);
                            if (meas[i].Lsaz != 0.0 & cbSAZ.Checked == true)
                            {
                                Lsaz[i].Text = Convert.ToString(meas[i].Lsaz + valueForAddLsaz + valueForAddDoubleLsaz + UpSAZValue);
                                double tc = Convert.ToDouble(Ltc[i].Text);
                                double sh2 = Convert.ToDouble(Lsh[i].Text);
                                double h2 = Convert.ToDouble(Lh[i].Text);
                                double saz = Convert.ToDouble(Lsaz[i].Text);
                                if ((tc > sh2) && (sh2 > h2) && (sh2 > saz) && (saz > h2))
                                {
                                    //labelwarn.Visible = false;
                                    //j=0;
                                }
                                else
                                {
                                    i--;
                                    //j++;
                                    //if (j > 500)
                                    //{
                                    //    labelwarn.Visible = true;
                                    //    labelwarn.Text = "Неверные данные!";
                                    //    labelwarn.BackColor = Color.Red;
                                    //    break;
                                    //}
                                }
                            }
                            else
                            {
                                double tc = Convert.ToDouble(Ltc[i].Text);
                                double sh2 = Convert.ToDouble(Lsh[i].Text);
                                double h2 = Convert.ToDouble(Lh[i].Text);
                                if ((tc > sh2) && (sh2 > h2))
                                {
                                    //labelwarn.Visible = false;
                                }
                                else
                                {
                                    i--;
                                    //j++;
                                    //if (j > 50)
                                    //{
                                    //    labelwarn.Visible = true;
                                    //    labelwarn.Text = "Измените поправку САЗ!";
                                    //    labelwarn.BackColor = Color.Red;
                                    //    break;
                                    //}
                                }
                            }
                        }
                    }
                }
                else
                {
                    //int j = 0;
                    if (meas.Count != 0)
                    {
                        for (int i = 0; i < meas.Count; i++)
                        {
                            Random rnd = new Random();
                            int valueForAddLtc = rnd.Next(-2, 2);
                            int valueForAddLsh = rnd.Next(-2, 2);
                            int valueForAddLh = rnd.Next(-2, 2);
                            int valueForAddLsaz = rnd.Next(-2, 2);
                            double valueForAddDoubleLtc = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            double valueForAddDoubleLsh = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            double valueForAddDoubleLh = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            double valueForAddDoubleLsaz = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                            Ltc[i].Text = Convert.ToString(meas[i].Ltc + valueForAddLtc + valueForAddDoubleLtc);
                            Lsh[i].Text = Convert.ToString(meas[i].Lsh + valueForAddLsh + valueForAddDoubleLsh);
                            Lh[i].Text = Convert.ToString(meas[i].Lh + valueForAddLh + valueForAddDoubleLh);
                            if (meas[i].Lsaz != 0.0 & cbSAZ.Checked == true)
                            {
                                Lsaz[i].Text = Convert.ToString(meas[i].Lsaz + valueForAddLsaz + valueForAddDoubleLsaz + UpSAZValue);
                                double tc = Convert.ToDouble(Ltc[i].Text);
                                double sh2 = Convert.ToDouble(Lsh[i].Text);
                                double h2 = Convert.ToDouble(Lh[i].Text);
                                double saz = Convert.ToDouble(Lsaz[i].Text);
                                if ((tc > sh2) && (sh2 > h2) && (sh2 > saz) && (saz > h2))
                                {
                                    //labelwarn.Visible = false;
                                }
                                else
                                {
                                    i--;
                                    //j++;
                                    //if (j > 50)
                                    //{
                                    //    labelwarn.Visible = true;
                                    //    labelwarn.Text = "Измените поправку САЗ!";
                                    //    labelwarn.BackColor = Color.Red;
                                    //    break;
                                    //}
                                }
                            }
                            else
                            {
                                double tc = Convert.ToDouble(Ltc[i].Text);
                                double sh2 = Convert.ToDouble(Lsh[i].Text);
                                double h2 = Convert.ToDouble(Lh[i].Text);
                                if ((tc > sh2) && (sh2 > h2))
                                {
                                    //labelwarn.Visible = false;
                                }
                                else
                                {
                                    i--;
                                    //j++;
                                    //if (j > 50)
                                    //{
                                    //    labelwarn.Visible = true;
                                    //    labelwarn.Text = "Измените поправку САЗ!";
                                    //    labelwarn.BackColor = Color.Red;
                                    //    break;
                                    //}
                                }
                            }
                        }
                    }
                }
                chart2.Series[0].Points.Clear();
                chart2.Series[1].Points.Clear();
                chart2.Series[2].Points.Clear();
                chart2.Series[3].Points.Clear();
                chart2.Series[4].Points.Clear();
                FillGistogram();
            }
        }

        private void TmrClock_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            string text = "";
            if (elapsed.Days > 0)
                text += elapsed.Days.ToString() + ".";

            int tenths = elapsed.Milliseconds / 100;

            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00") + "." +
                tenths.ToString("0");

            lblElapsed.Text = text;
        }

        private void ComboBoxGFDSpeechLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGFDSpeechLevel.Text == "70 дБ")
            {
                comboBoxSpeechLevel.SelectedIndex = 0;
            }
            else
            {
                comboBoxSpeechLevel.SelectedIndex = 1;
            }
            List<GenerationFirstMeasurement> listGenerationFirstMeasurement = db.GenerationFirstMeasurements.ToList();
            foreach (GenerationFirstMeasurement generationFirstMeasurement in listGenerationFirstMeasurement)
            {
                if ((Convert.ToString(generationFirstMeasurement.Lsaz) != "0") /*& (comboBoxGFDSpeechLevel.Text == Convert.ToString(generationFirstMeasurement.SpeechLevel))*/)
                {
                    cbSAZavailability.Checked = true;
                    cbSAZ.Enabled = true;
                    label111.Enabled = true;
                    tBSAZUp.Enabled = true;
                    btnUpDwSAZ.Enabled = true;
                }
                else
                {
                    cbSAZavailability.Checked = false;
                    cbSAZ.Checked = false;
                    cbSAZ.Enabled = false;
                    label111.Enabled = false;
                    tBSAZUp.Enabled = false;
                    btnUpDwSAZ.Enabled = false;
                }
            }
        }

        private void ComboBoxConstructionThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            db = new ShepotSim.ApplicationContext();
            comboBoxGFDSpeechLevel.Items.Clear();
            List<GenerationFirstCheckPoint> listGenerationFirstCheckPoint = db.GenerationFirstCheckPoints.ToList();
            foreach (GenerationFirstCheckPoint generationFirstCheckPoint in listGenerationFirstCheckPoint)
            {
                if (comboBoxGFData.Text == generationFirstCheckPoint.GFCheckPointName)
                {
                    comboBoxGFDSpeechLevel.Items.AddRange(new object[2]
                    {
                        "70 дБ",
                        "84 дБ"
                    });
                    comboBoxGFDSpeechLevel.SelectedIndex = 0;
                    //Жалко удалять то, что снизу, я сделал сортировку по уровням речи (в таблице GFM удалил дополнительно уровень речи)
                    //List<GenerationFirstMeasurement> listGenerationFirstMeasurement = db.GenerationFirstMeasurements.ToList();
                    //foreach (GenerationFirstMeasurement generationFirstMeasurement in listGenerationFirstMeasurement)
                    //{
                    //    if ((generationFirstCheckPoint.GenerationFirstCheckPointId == generationFirstMeasurement.GenerationFirstCheckPointId) & (!comboBoxGFDSpeechLevel.Items.Contains(generationFirstMeasurement.SpeechLevel/* + " дБ"*/)) & (comboBoxConstructionThickness.Text == Convert.ToString(generationFirstMeasurement.ConstructionThickness)))
                    //    {
                    //        comboBoxGFDSpeechLevel.Items.Add(generationFirstMeasurement.SpeechLevel/* + " дБ"*/);
                    //    }
                    //}
                }
            }
        }

        private void cbSZYforGFD_CheckedChanged(object sender, EventArgs e)
        {
            List<GenerationFirstCheckPoint> listGenerationFirstCheckPoint = db.GenerationFirstCheckPoints.ToList();
            foreach (GenerationFirstCheckPoint generationFirstCheckPoint in listGenerationFirstCheckPoint)
            {
                if (comboBoxGFData.Text == generationFirstCheckPoint.GFCheckPointName)
                {
                    List<GenerationFirstMeasurement> listGenerationFirstMeasurement = db.GenerationFirstMeasurements.ToList();
                    foreach (GenerationFirstMeasurement generationFirstMeasurement in listGenerationFirstMeasurement)
                    {
                        if ((generationFirstCheckPoint.GenerationFirstCheckPointId == generationFirstMeasurement.GenerationFirstCheckPointId) & (comboBoxConstructionThickness.Text == generationFirstMeasurement.ConstructionThickness))
                        {
                            if (cbSZYforGFD.Checked == true)
                            {
                                comboBoxGFDSpeechLevel.SelectedIndex = 1;
                                cbSZY.Checked = true;
                            }
                            else
                            {
                                comboBoxGFDSpeechLevel.SelectedIndex = 0;
                                cbSZY.Checked = false;
                            }
                        }
                    }
                }
            }
        }

        private void LoadPovData()
        {
            for (int i = 0; i < PovDatamVPa1.Count + PovDatadB2.Count; i++)
            {
                db = new ShepotSim.ApplicationContext();
                List<VerificationValue> verval = new List<VerificationValue>();
                List<VerificationValue> listVerificationValue = db.VerificationValues.ToList();
                foreach (VerificationValue verificationvalue in listVerificationValue)
                {
                    verval.Add(verificationvalue);
                }
                Random rnd = new Random();
                int valueForAdd = rnd.Next(-2, 2);
                double valueForAddDouble = Math.Round(rnd.NextDouble() * 2 - 1, 1);
                if (verval[i].DeviceID == 1)
                {
                    PovDatamVPa1[i].Text = Convert.ToString(verval[i].ValueVerificationValue + valueForAdd + valueForAddDouble);
                }
                if (verval[i].DeviceID == 2)
                {
                    PovDatadB2[i - 7].Text = Convert.ToString(verval[i].ValueVerificationValue + valueForAdd + valueForAddDouble);
                }
            }
        }

        private void btnCheckRightConvMic_Click(object sender, EventArgs e)
        {
            ConvCalculationMic1();
        }

        private void ShorohCalculation()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                for (int i = 0; i < EiAfter.Count; i++)
                {
                    if (NeedCorrect[i].Text == "да")
                    {
                        //bool saz = false; // прошлая версия
                        //if (Lsaz[0].Text != "")
                        //{
                        //    saz = true;
                        //}
                        do
                        {
                            double sumshum = Convert.ToDouble(SumShum[i].Text) + 1.1;
                            SumShum[i].Text = Convert.ToString(sumshum);
                            double uplhorlsaz = Convert.ToDouble(UpLhorLsaz[i].Text) + 1.1;
                            UpLhorLsaz[i].Text = Convert.ToString(uplhorlsaz);
                            //bool saz = false; // прошлая версия
                            //if (Lsaz[0].Text != "")
                            //{
                            //    saz = true;
                            //}
                            //if (saz == true)
                            //{
                            //    double lsaz = Convert.ToDouble(Lsaz[i].Text) + 1/*0.1*/;
                            //    Lsaz[i].Text = Convert.ToString(lsaz);
                            //}
                            //else
                            //{
                            //    double lh = Convert.ToDouble(Lh[i].Text) + 1/*0.1*/;
                            //    Lh[i].Text = Convert.ToString(lh);
                            //} // прошлая версия
                            //double lh = Convert.ToDouble(Lh[i].Text) + 0.1; // это просто для шума
                            //Lh[i].Text = Convert.ToString(lh); // это просто для шума
                            double[,] octav = new double[3, 7]
                            {
                                {
                                    87.5,
                                    175.0,
                                    350.0,
                                    700.0,
                                    1400.0,
                                    2800.0,
                                    5600.0
                                },
                                {
                                    175.0,
                                    350.0,
                                    700.0,
                                    1400.0,
                                    2800.0,
                                    5600.0,
                                    11200.0
                                },
                                {
                                    125.0,
                                    250.0,
                                    500.0,
                                    1000.0,
                                    2000.0,
                                    4000.0,
                                    8000.0
                                }
                            };
                            double tc = Convert.ToDouble(Ltc[i].Text);
                            double sh = Convert.ToDouble(Lsh[i].Text);
                            double h2 = 0.0;
                            h2 = sumshum;
                            //h2 = ((!saz) ? Convert.ToDouble(Lh[i].Text) : Convert.ToDouble(Lsaz[i].Text)); // прошлая версия
                            //h2 = Convert.ToDouble(Lh[i].Text); // это просто для шума
                            double c = 10.0 * Math.Log10(Math.Pow(10.0, 0.1 * sh) - Math.Pow(10.0, 0.1 * h2));
                            int f2 = 0;
                            f2 = (Ltc.Count != 7) ? Convert.ToInt32(octav[2, i + 1]) : Convert.ToInt32(octav[2, i]);
                            double Ln2 = 0.0;
                            Ln2 = ((comboBoxSpeechLevel.SelectedIndex != 0) ? GetLn(84, f2) : GetLn(70, f2));
                            double D = tc - Ln2;
                            double e1 = c - h2 - D;
                            EiAfter[i].Text = Convert.ToString(Math.Round(e1, 2));
                        } while ((Convert.ToDouble(Lsh[i].Text) > (/*(!cbSAZ.Checked или лучше saz == true) ? Convert.ToDouble(Lh[i].Text) + 2 : Convert.ToDouble(Lsaz[i].Text) + 2 /*прошлая версия*/Convert.ToDouble(SumShum[i].Text) + 2)) && (Convert.ToInt32(NormMeas2[i].Text) < Convert.ToDouble(EiAfter[i].Text)));
                        //if (NormMeas2[i].Text != "" & EiAfter[i].Text != "") // прошлая версия
                        //{
                        //    if (Convert.ToInt32(NormMeas2[i].Text) < Convert.ToDouble(EiAfter[i].Text))
                        //    {
                        //        NeedCorrect[i].Text = "да";
                        //        NeedCorrect[i].BackColor = Color.Red;
                        //    }
                        //    else
                        //    {
                        //        NeedCorrect[i].Text = "нет";
                        //        NeedCorrect[i].BackColor = Color.LimeGreen;
                        //    }
                        //}
                        for (int j = 0; j < EiAfter.Count; j++)
                        {
                            if ((UpLhorLsaz[i].Text == UpLhorLsaz[j].Text) & (i != j))
                            {
                                double sumshum = Convert.ToDouble(SumShum[i].Text) + 0.3;
                                SumShum[i].Text = Convert.ToString(sumshum);
                                double uplhorlsaz = Convert.ToDouble(UpLhorLsaz[i].Text) + 0.3;
                                UpLhorLsaz[i].Text = Convert.ToString(uplhorlsaz);
                                double[,] octav = new double[3, 7]
                                {
                                    {
                                        87.5,
                                        175.0,
                                        350.0,
                                        700.0,
                                        1400.0,
                                        2800.0,
                                        5600.0
                                    },
                                    {
                                        175.0,
                                        350.0,
                                        700.0,
                                        1400.0,
                                        2800.0,
                                        5600.0,
                                        11200.0
                                    },
                                    {
                                        125.0,
                                        250.0,
                                        500.0,
                                        1000.0,
                                        2000.0,
                                        4000.0,
                                        8000.0
                                    }
                                };
                                double tc = Convert.ToDouble(Ltc[i].Text);
                                double sh = Convert.ToDouble(Lsh[i].Text);
                                double h2 = 0.0;
                                h2 = sumshum;
                                double c = 10.0 * Math.Log10(Math.Pow(10.0, 0.1 * sh) - Math.Pow(10.0, 0.1 * h2));
                                int f2 = 0;
                                f2 = (Ltc.Count != 7) ? Convert.ToInt32(octav[2, i + 1]) : Convert.ToInt32(octav[2, i]);
                                double Ln2 = 0.0;
                                Ln2 = ((comboBoxSpeechLevel.SelectedIndex != 0) ? GetLn(84, f2) : GetLn(70, f2));
                                double D = tc - Ln2;
                                double e1 = c - h2 - D;
                                EiAfter[i].Text = Convert.ToString(Math.Round(e1, 2));
                            }
                        }
                    }
                }
                //if (DataChecking()) // прошлая версия
                //{
                //    IntelligibilityCalculation();
                //    if (tBR.Text == "да")
                //    {
                //        tBR.BackColor = Color.LimeGreen;
                //    }
                //    else if (tBR.Text == "нет")
                //    {
                //        tBR.BackColor = Color.Red;
                //    }
                //}
            }
        }

        private void AgreeChangesOfLhOrLsaz()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                for (int i = 0; i < EiAfter.Count; i++)
                {
                    if (NeedCorrect[i].Text == "да")
                    {
                        bool saz = false;
                        if (Lsaz[0].Text != "")
                        {
                            saz = true;
                        }
                        if (saz == true)
                        {
                            Lsaz[i].Text = SumShum[i].Text;
                        }
                        else
                        {
                            Lh[i].Text = SumShum[i].Text;
                        }
                        label1177.Text = "Выполнено успешно";
                        label1177.BackColor = Color.LimeGreen;
                        if (NormMeas2[i].Text != "" & EiAfter[i].Text != "")
                        {
                            if (Convert.ToInt32(NormMeas2[i].Text) < Convert.ToDouble(EiAfter[i].Text))
                            {
                                NeedCorrect[i].Text = "да";
                                NeedCorrect[i].BackColor = Color.Red;
                            }
                            else
                            {
                                NeedCorrect[i].Text = "нет";
                                NeedCorrect[i].BackColor = Color.LimeGreen;
                            }
                        }
                    }
                }
                label128.BackColor = Color.White;
                label128.ForeColor = Color.Black;
                label129.BackColor = Color.White;
                label129.ForeColor = Color.Black;
                label130.BackColor = Color.White;
                label130.ForeColor = Color.Black;
                label131.BackColor = Color.White;
                label131.ForeColor = Color.Black;
                if (DataChecking())
                {
                    IntelligibilityCalculation();
                    if (tBR.Text == "да")
                    {
                        tBR.BackColor = Color.LimeGreen;
                    }
                    else if (tBR.Text == "нет")
                    {
                        tBR.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnNormEiMeas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < NormMeas.Count; i++)
            {
                if (NormMeas[i].Text != "")
                {
                    try
                    {
                        int ch = Convert.ToInt32(NormMeas[i].Text);
                        NormMeas2[i].Text = NormMeas[i].Text;
                        NormMeas[i].BackColor = Color.White;
                    }
                    catch
                    {
                        NormMeas[i].BackColor = Color.Red;
                    }
                }
            }
            for (int i = 0; i < EiAfter.Count; i++)
            {
                if (NormMeas2[i].Text != "" & EiAfter[i].Text != "")
                {
                    if (Convert.ToInt32(NormMeas2[i].Text) < Convert.ToDouble(EiAfter[i].Text))
                    {
                        NeedCorrect[i].Text = "да";
                        NeedCorrect[i].BackColor = Color.Red;
                    }
                    else
                    {
                        NeedCorrect[i].Text = "нет";
                        NeedCorrect[i].BackColor = Color.LimeGreen;
                    }
                }
            }
            ShorohCalculation();
            label1177.Text = "";
            label1177.BackColor = Color.White;
        }

        private void btnGetUpLh_Click(object sender, EventArgs e)
        {
            AgreeChangesOfLhOrLsaz();
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();
            chart2.Series[4].Points.Clear();
            FillGistogramAfterUseShoroh();
            //ShorohCalculation(); прошлая версия
        }

        private void ConvCalculationMic1()
        {
            int j = 0;
            for (int i = 0; i < PovDatadB1.Count; i++)
            {
                db = new ShepotSim.ApplicationContext();
                List<VerificationValue> verval = new List<VerificationValue>();
                List<VerificationValue> listVerificationValue = db.VerificationValues.ToList();
                foreach (VerificationValue verificationvalue in listVerificationValue)
                {
                    verval.Add(verificationvalue);
                }
                double checkvalue = Convert.ToDouble(PovDatamVPa1[i].Text);
                double N = Math.Round(20 * Math.Log10(checkvalue / 1000), 1);
                if (PovDatadB1[i].Text != "")
                {
                    if (N == Convert.ToDouble(PovDatadB1[i].Text))
                    {
                        PovDatadB1[i].BackColor = Color.LimeGreen;
                        j++;
                    }
                    else
                    {
                        PovDatadB1[i].BackColor = Color.Red;
                        label114.Text = "Ошибка / нет данных!";
                        label114.BackColor = Color.Red;
                    }
                    if (j == 7)
                    {
                        label114.Text = "Выполнено успешно";
                        label114.BackColor = Color.LimeGreen;
                    }
                }
                else
                {
                    PovDatadB1[i].BackColor = Color.Red;
                    label114.Text = "Ошибка / нет данных!";
                    label114.BackColor = Color.Red;
                }
            }
        }

        private void ConvCalculationMic2()
        {
            int j = 0;
            for (int i = 0; i < PovDatamVPa2.Count; i++)
            {
                db = new ShepotSim.ApplicationContext();
                List<VerificationValue> verval = new List<VerificationValue>();
                List<VerificationValue> listVerificationValue = db.VerificationValues.ToList();
                foreach (VerificationValue verificationvalue in listVerificationValue)
                {
                    verval.Add(verificationvalue);
                }
                double checkvalue = Convert.ToDouble(PovDatadB2[i].Text);
                double E = Math.Round(1000 * Math.Pow(10, (checkvalue / 20)), 2);
                if (PovDatamVPa2[i].Text != "")
                {
                    if (E == Convert.ToDouble(PovDatamVPa2[i].Text))
                    {
                        PovDatamVPa2[i].BackColor = Color.LimeGreen;
                        j++;
                    }
                    else
                    {
                        PovDatamVPa2[i].BackColor = Color.Red;
                        label115.Text = "Ошибка / нет данных!";
                        label115.BackColor = Color.Red;
                    }
                    if (j == 7)
                    {
                        label115.Text = "Выполнено успешно";
                        label115.BackColor = Color.LimeGreen;
                    }
                }
                else
                {
                    PovDatamVPa2[i].BackColor = Color.Red;
                    label115.Text = "Ошибка / нет данных!";
                    label115.BackColor = Color.Red;
                }
            }
        }

        private void btnCheckRightConvMic2_Click(object sender, EventArgs e)
        {
            ConvCalculationMic2();
        }

        private void buttonCleanMeasurement_Click(object sender, EventArgs e)
        {
            foreach (Control tB2 in groupBoxMeasurementResults.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
        }

        private void btnClearW_Click(object sender, EventArgs e)
        {
            foreach (Control tB in groupBoxIntelligibility.Controls)
            {
                if (tB is TextBox)
                {
                    tB.Text = "";
                    tB.BackColor = Color.White;
                }
            }
        }

        private void btnClearQi_Click(object sender, EventArgs e)
        {
            foreach (Control tB2 in groupBoxSoundproofing.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
        }

        private void btnClearShoroh_Click(object sender, EventArgs e)
        {
            foreach (Control tB2 in groupBoxShoroh.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
            label1177.Text = "";
            label1177.BackColor = Color.White;
        }

        private void btnClearPovData_Click(object sender, EventArgs e)
        {
            foreach (Control tB2 in PovDatadB1)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
            foreach (Control tB2 in PovDatamVPa2)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
        }

        private void btnClearNormValue_Click(object sender, EventArgs e)
        {
            foreach (Control tB2 in groupBoxNormValue.Controls)
            {
                if (tB2 is TextBox)
                {
                    tB2.Text = "";
                    tB2.BackColor = Color.White;
                }
            }
        }

        private void btnRefreshShoroh_Click(object sender, EventArgs e)
        {
            label1177.Text = "";
            label1177.BackColor = Color.White;
            label128.BackColor = Color.White;
            label128.ForeColor = Color.Black;
            label129.BackColor = Color.White;
            label129.ForeColor = Color.Black;
            label130.BackColor = Color.White;
            label130.ForeColor = Color.Black;
            label131.BackColor = Color.White;
            label131.ForeColor = Color.Black;
            if (DataChecking())
            {
                IntelligibilityCalculation();
                if (tBR.Text == "да")
                {
                    tBR.BackColor = Color.LimeGreen;
                }
                else if (tBR.Text == "нет")
                {
                    tBR.BackColor = Color.Red;
                }
            }
            for (int i = 0; i < NormMeas.Count; i++)
            {
                if (NormMeas[i].Text != "")
                {
                    try
                    {
                        int ch = Convert.ToInt32(NormMeas[i].Text);
                        NormMeas2[i].Text = NormMeas[i].Text;
                        NormMeas[i].BackColor = Color.White;
                    }
                    catch
                    {
                        NormMeas[i].BackColor = Color.Red;
                    }
                }
            }
            for (int i = 0; i < EiAfter.Count; i++)
            {
                if (NormMeas2[i].Text != "" & EiAfter[i].Text != "")
                {
                    if (Convert.ToInt32(NormMeas2[i].Text) < Convert.ToDouble(EiAfter[i].Text))
                    {
                        NeedCorrect[i].Text = "да";
                        NeedCorrect[i].BackColor = Color.Red;
                    }
                    else
                    {
                        NeedCorrect[i].Text = "нет";
                        NeedCorrect[i].BackColor = Color.LimeGreen;
                    }
                }
            }
            ShorohCalculation();
        }

        private int UpSAZValue = 0;
        private void btnUpDwSAZ_Click(object sender, EventArgs e)
        {
            UpSAZValue = Convert.ToInt32(tBSAZUp.Text);
        }

        private void FillGistogram()
        {
            chart2.Series["Ltc"].LegendText = "Уровень тест-сигнала";
            chart2.Series["Ltc"].Points.AddXY(125, Convert.ToDouble(tBLtc1.Text));
            chart2.Series["Ltc"].Points.AddXY(250, Convert.ToDouble(tBLtc2.Text));
            chart2.Series["Ltc"].Points.AddXY(500, Convert.ToDouble(tBLtc3.Text));
            chart2.Series["Ltc"].Points.AddXY(1000, Convert.ToDouble(tBLtc4.Text));
            chart2.Series["Ltc"].Points.AddXY(2000, Convert.ToDouble(tBLtc5.Text));
            chart2.Series["Ltc"].Points.AddXY(4000, Convert.ToDouble(tBLtc6.Text));
            chart2.Series["Ltc"].Points.AddXY(8000, Convert.ToDouble(tBLtc7.Text));

            chart2.Series["Lsh"].LegendText = "Уровень сигнала и шума";
            chart2.Series["Lsh"].Points.AddXY(125, Convert.ToDouble(tBLsh1.Text));
            chart2.Series["Lsh"].Points.AddXY(250, Convert.ToDouble(tBLsh2.Text));
            chart2.Series["Lsh"].Points.AddXY(500, Convert.ToDouble(tBLsh3.Text));
            chart2.Series["Lsh"].Points.AddXY(1000, Convert.ToDouble(tBLsh4.Text));
            chart2.Series["Lsh"].Points.AddXY(2000, Convert.ToDouble(tBLsh5.Text));
            chart2.Series["Lsh"].Points.AddXY(4000, Convert.ToDouble(tBLsh6.Text));
            chart2.Series["Lsh"].Points.AddXY(8000, Convert.ToDouble(tBLsh7.Text));

            chart2.Series["Lh"].LegendText = "Уровень фонового шума";
            chart2.Series["Lh"].Points.AddXY(125, Convert.ToDouble(tBLh1.Text));
            chart2.Series["Lh"].Points.AddXY(250, Convert.ToDouble(tBLh2.Text));
            chart2.Series["Lh"].Points.AddXY(500, Convert.ToDouble(tBLh3.Text));
            chart2.Series["Lh"].Points.AddXY(1000, Convert.ToDouble(tBLh4.Text));
            chart2.Series["Lh"].Points.AddXY(2000, Convert.ToDouble(tBLh5.Text));
            chart2.Series["Lh"].Points.AddXY(4000, Convert.ToDouble(tBLh6.Text));
            chart2.Series["Lh"].Points.AddXY(8000, Convert.ToDouble(tBLh7.Text));

            //chart2.Series["LsazShoroh"].LegendText = "";
            //chart2.Series["LsazShoroh"].Color = Color.White;

            if (tBLsaz1.Text != "")
            {
                chart2.Series["Lsaz"].LegendText = "Уровень шума от САЗ";
                chart2.Series["Lsaz"].Points.AddXY(125, Convert.ToDouble(tBLsaz1.Text));
                chart2.Series["Lsaz"].Points.AddXY(250, Convert.ToDouble(tBLsaz2.Text));
                chart2.Series["Lsaz"].Points.AddXY(500, Convert.ToDouble(tBLsaz3.Text));
                chart2.Series["Lsaz"].Points.AddXY(1000, Convert.ToDouble(tBLsaz4.Text));
                chart2.Series["Lsaz"].Points.AddXY(2000, Convert.ToDouble(tBLsaz5.Text));
                chart2.Series["Lsaz"].Points.AddXY(4000, Convert.ToDouble(tBLsaz6.Text));
                chart2.Series["Lsaz"].Points.AddXY(8000, Convert.ToDouble(tBLsaz7.Text));
            }
        }

        private void btnAuthorizationToSim_Click(object sender, EventArgs e)
        {
            LoginForm2 form2 = new LoginForm2();
            form2.ShowDialog();
        }

        private void btnCallAccountForm_Click(object sender, EventArgs e)
        {
            if (Data.Value != 0)
            {
                AccountForm3 form3 = new AccountForm3();
                form3.ShowDialog();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Войдите в аккаунт", "Нет доступа", MessageBoxButtons.OK);
            }
        }

        private void btnExitFromAccount_Click(object sender, EventArgs e)
        {
            CleanPageCheckPoint();
            treeViewStructure.Nodes.Clear();
            Data.Value = 0;
            Text = "СОЗ Шепот (учебный стенд)";
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();
            chart2.Series[2].Points.Clear();
            chart2.Series[3].Points.Clear();
            chart2.Series[4].Points.Clear();
        }

        private void btnHideLeftBlock_Click(object sender, EventArgs e)
        {
            if (btnHideLeftBlock.Text == ">>>>>")
            {
                btnHideLeftBlock.Text = "<<<<<";
                treeViewStructure.Width = 0;
                groupBox5.Width = 0;
                groupBox6.Width = 0;
                label55.Visible = false;
                btnAboutMyProgram.Width = 0;
                btnHideLeftBlock.Location = new System.Drawing.Point(1, -1);
                tabControl1.Location = new System.Drawing.Point(18, -3);
                Program.f1.Size = new Size(843, 643);
            }
            else
            {
                btnHideLeftBlock.Text = ">>>>>";
                treeViewStructure.Width = 155;
                groupBox5.Width = 155;
                groupBox6.Width = 155;
                label55.Visible = true;
                btnAboutMyProgram.Width = 86;
                btnHideLeftBlock.Location = new System.Drawing.Point(165, -1);
                tabControl1.Location = new System.Drawing.Point(182, -3);
                Program.f1.Size = new Size(1007, 643);
            }
        }

        private void btnAboutMyProgram_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ВКР 2020 Учебный стенд расчета и оценки показателей защищенности речевой информации ограниченного доступа, Барабаш Д.М., dmitry874@yandex.ru", "О программе", MessageBoxButtons.OK);
        }

        private void FillGistogramAfterUseShoroh()
        {
            chart2.Series["Ltc"].LegendText = "Уровень тест-сигнала";
            chart2.Series["Ltc"].Points.AddXY(125, Convert.ToDouble(tBLtc1.Text));
            chart2.Series["Ltc"].Points.AddXY(250, Convert.ToDouble(tBLtc2.Text));
            chart2.Series["Ltc"].Points.AddXY(500, Convert.ToDouble(tBLtc3.Text));
            chart2.Series["Ltc"].Points.AddXY(1000, Convert.ToDouble(tBLtc4.Text));
            chart2.Series["Ltc"].Points.AddXY(2000, Convert.ToDouble(tBLtc5.Text));
            chart2.Series["Ltc"].Points.AddXY(4000, Convert.ToDouble(tBLtc6.Text));
            chart2.Series["Ltc"].Points.AddXY(8000, Convert.ToDouble(tBLtc7.Text));

            chart2.Series["Lsh"].LegendText = "Уровень сигнала и шума";
            chart2.Series["Lsh"].Points.AddXY(125, Convert.ToDouble(tBLsh1.Text));
            chart2.Series["Lsh"].Points.AddXY(250, Convert.ToDouble(tBLsh2.Text));
            chart2.Series["Lsh"].Points.AddXY(500, Convert.ToDouble(tBLsh3.Text));
            chart2.Series["Lsh"].Points.AddXY(1000, Convert.ToDouble(tBLsh4.Text));
            chart2.Series["Lsh"].Points.AddXY(2000, Convert.ToDouble(tBLsh5.Text));
            chart2.Series["Lsh"].Points.AddXY(4000, Convert.ToDouble(tBLsh6.Text));
            chart2.Series["Lsh"].Points.AddXY(8000, Convert.ToDouble(tBLsh7.Text));

            chart2.Series["Lh"].LegendText = "Уровень фонового шума";
            chart2.Series["Lh"].Points.AddXY(125, Convert.ToDouble(tBLh1.Text));
            chart2.Series["Lh"].Points.AddXY(250, Convert.ToDouble(tBLh2.Text));
            chart2.Series["Lh"].Points.AddXY(500, Convert.ToDouble(tBLh3.Text));
            chart2.Series["Lh"].Points.AddXY(1000, Convert.ToDouble(tBLh4.Text));
            chart2.Series["Lh"].Points.AddXY(2000, Convert.ToDouble(tBLh5.Text));
            chart2.Series["Lh"].Points.AddXY(4000, Convert.ToDouble(tBLh6.Text));
            chart2.Series["Lh"].Points.AddXY(8000, Convert.ToDouble(tBLh7.Text));

            if (tBLsaz1.Text != "")
            {
                chart2.Series["LsazShoroh"].LegendText = "Уровень шума от САЗ после поправки";
                chart2.Series["LsazShoroh"].Points.AddXY(125, Convert.ToDouble(tBLsaz1.Text));
                chart2.Series["LsazShoroh"].Points.AddXY(250, Convert.ToDouble(tBLsaz2.Text));
                chart2.Series["LsazShoroh"].Points.AddXY(500, Convert.ToDouble(tBLsaz3.Text));
                chart2.Series["LsazShoroh"].Points.AddXY(1000, Convert.ToDouble(tBLsaz4.Text));
                chart2.Series["LsazShoroh"].Points.AddXY(2000, Convert.ToDouble(tBLsaz5.Text));
                chart2.Series["LsazShoroh"].Points.AddXY(4000, Convert.ToDouble(tBLsaz6.Text));
                chart2.Series["LsazShoroh"].Points.AddXY(8000, Convert.ToDouble(tBLsaz7.Text));
            }
        }

        private void btnChooseHelp_Click(object sender, EventArgs e)
        {
            ChooseHelpForm5 form5 = new ChooseHelpForm5();
            form5.ShowDialog();
        }

        private void btnLogging1_Click(object sender, EventArgs e)
        {
            Logging(1);
        }

        private void Logging(int flagOfLog)
        {
            var wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = false;
            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{Ltc1}", tBLtc1.Text, wordDocument);
                ReplaceWordStub("{Ltc2}", tBLtc2.Text, wordDocument);
                ReplaceWordStub("{Ltc3}", tBLtc3.Text, wordDocument);
                ReplaceWordStub("{Ltc4}", tBLtc4.Text, wordDocument);
                ReplaceWordStub("{Ltc5}", tBLtc5.Text, wordDocument);
                ReplaceWordStub("{Ltc6}", tBLtc6.Text, wordDocument);
                ReplaceWordStub("{Ltc7}", tBLtc7.Text, wordDocument);
                ReplaceWordStub("{Lsh1}", tBLsh1.Text, wordDocument);
                ReplaceWordStub("{Lsh2}", tBLsh2.Text, wordDocument);
                ReplaceWordStub("{Lsh3}", tBLsh3.Text, wordDocument);
                ReplaceWordStub("{Lsh4}", tBLsh4.Text, wordDocument);
                ReplaceWordStub("{Lsh5}", tBLsh5.Text, wordDocument);
                ReplaceWordStub("{Lsh6}", tBLsh6.Text, wordDocument);
                ReplaceWordStub("{Lsh7}", tBLsh7.Text, wordDocument);
                ReplaceWordStub("{Lh1}", tBLh1.Text, wordDocument);
                ReplaceWordStub("{Lh2}", tBLh2.Text, wordDocument);
                ReplaceWordStub("{Lh3}", tBLh3.Text, wordDocument);
                ReplaceWordStub("{Lh4}", tBLh4.Text, wordDocument);
                ReplaceWordStub("{Lh5}", tBLh5.Text, wordDocument);
                ReplaceWordStub("{Lh6}", tBLh6.Text, wordDocument);
                ReplaceWordStub("{Lh7}", tBLh7.Text, wordDocument);
                ReplaceWordStub("{Lsaz1}", tBLsaz1.Text, wordDocument);
                ReplaceWordStub("{Lsaz2}", tBLsaz2.Text, wordDocument);
                ReplaceWordStub("{Lsaz3}", tBLsaz3.Text, wordDocument);
                ReplaceWordStub("{Lsaz4}", tBLsaz4.Text, wordDocument);
                ReplaceWordStub("{Lsaz5}", tBLsaz5.Text, wordDocument);
                ReplaceWordStub("{Lsaz6}", tBLsaz6.Text, wordDocument);
                ReplaceWordStub("{Lsaz7}", tBLsaz7.Text, wordDocument);
                ReplaceWordStub("{Lc21}", tBLc21.Text, wordDocument);
                ReplaceWordStub("{Lc22}", tBLc22.Text, wordDocument);
                ReplaceWordStub("{Lc23}", tBLc23.Text, wordDocument);
                ReplaceWordStub("{Lc24}", tBLc24.Text, wordDocument);
                ReplaceWordStub("{Lc25}", tBLc25.Text, wordDocument);
                ReplaceWordStub("{Lc26}", tBLc26.Text, wordDocument);
                ReplaceWordStub("{Lc27}", tBLc27.Text, wordDocument);
                ReplaceWordStub("{Ln1}", tBLn1.Text, wordDocument);
                ReplaceWordStub("{Ln2}", tBLn2.Text, wordDocument);
                ReplaceWordStub("{Ln3}", tBLn3.Text, wordDocument);
                ReplaceWordStub("{Ln4}", tBLn4.Text, wordDocument);
                ReplaceWordStub("{Ln5}", tBLn5.Text, wordDocument);
                ReplaceWordStub("{Ln6}", tBLn6.Text, wordDocument);
                ReplaceWordStub("{Ln7}", tBLn7.Text, wordDocument);
                ReplaceWordStub("{D1}", tBD1.Text, wordDocument);
                ReplaceWordStub("{D2}", tBD2.Text, wordDocument);
                ReplaceWordStub("{D3}", tBD3.Text, wordDocument);
                ReplaceWordStub("{D4}", tBD4.Text, wordDocument);
                ReplaceWordStub("{D5}", tBD5.Text, wordDocument);
                ReplaceWordStub("{D6}", tBD6.Text, wordDocument);
                ReplaceWordStub("{D7}", tBD7.Text, wordDocument);
                ReplaceWordStub("{E1}", tBE1.Text, wordDocument);
                ReplaceWordStub("{E2}", tBE2.Text, wordDocument);
                ReplaceWordStub("{E3}", tBE3.Text, wordDocument);
                ReplaceWordStub("{E4}", tBE4.Text, wordDocument);
                ReplaceWordStub("{E5}", tBE5.Text, wordDocument);
                ReplaceWordStub("{E6}", tBE6.Text, wordDocument);
                ReplaceWordStub("{E7}", tBE7.Text, wordDocument);
                ReplaceWordStub("{A1}", tBA1.Text, wordDocument);
                ReplaceWordStub("{A2}", tBA2.Text, wordDocument);
                ReplaceWordStub("{A3}", tBA3.Text, wordDocument);
                ReplaceWordStub("{A4}", tBA4.Text, wordDocument);
                ReplaceWordStub("{A5}", tBA5.Text, wordDocument);
                ReplaceWordStub("{A6}", tBA6.Text, wordDocument);
                ReplaceWordStub("{A7}", tBA7.Text, wordDocument);
                ReplaceWordStub("{qi1}", tBqi1.Text, wordDocument);
                ReplaceWordStub("{qi2}", tBqi2.Text, wordDocument);
                ReplaceWordStub("{qi3}", tBqi3.Text, wordDocument);
                ReplaceWordStub("{qi4}", tBqi4.Text, wordDocument);
                ReplaceWordStub("{qi5}", tBqi5.Text, wordDocument);
                ReplaceWordStub("{qi6}", tBqi6.Text, wordDocument);
                ReplaceWordStub("{qi7}", tBqi7.Text, wordDocument);
                ReplaceWordStub("{p1}", tBp1.Text, wordDocument);
                ReplaceWordStub("{p2}", tBp2.Text, wordDocument);
                ReplaceWordStub("{p3}", tBp3.Text, wordDocument);
                ReplaceWordStub("{p4}", tBp4.Text, wordDocument);
                ReplaceWordStub("{p5}", tBp5.Text, wordDocument);
                ReplaceWordStub("{p6}", tBp6.Text, wordDocument);
                ReplaceWordStub("{p7}", tBp7.Text, wordDocument);
                ReplaceWordStub("{k1}", tBk1.Text, wordDocument);
                ReplaceWordStub("{k2}", tBk2.Text, wordDocument);
                ReplaceWordStub("{k3}", tBk3.Text, wordDocument);
                ReplaceWordStub("{k4}", tBk4.Text, wordDocument);
                ReplaceWordStub("{k5}", tBk5.Text, wordDocument);
                ReplaceWordStub("{k6}", tBk6.Text, wordDocument);
                ReplaceWordStub("{k7}", tBk7.Text, wordDocument);
                ReplaceWordStub("{r1}", tBr1.Text, wordDocument);
                ReplaceWordStub("{r2}", tBr2.Text, wordDocument);
                ReplaceWordStub("{r3}", tBr3.Text, wordDocument);
                ReplaceWordStub("{r4}", tBr4.Text, wordDocument);
                ReplaceWordStub("{r5}", tBr5.Text, wordDocument);
                ReplaceWordStub("{r6}", tBr6.Text, wordDocument);
                ReplaceWordStub("{r7}", tBr7.Text, wordDocument);
                ReplaceWordStub("{W}", tBW.Text, wordDocument);
                ReplaceWordStub("{R}", tBR.Text, wordDocument);
                ReplaceWordStub("{N}", tBN.Text, wordDocument);
                ReplaceWordStub("{ChannelCP}", comboBoxChannelCheckPoint.Text, wordDocument);
                ReplaceWordStub("{Lc11}", tBLc11.Text, wordDocument);
                ReplaceWordStub("{Lc12}", tBLc12.Text, wordDocument);
                ReplaceWordStub("{Lc13}", tBLc13.Text, wordDocument);
                ReplaceWordStub("{Lc14}", tBLc14.Text, wordDocument);
                ReplaceWordStub("{Lc15}", tBLc15.Text, wordDocument);
                ReplaceWordStub("{Lc16}", tBLc16.Text, wordDocument);
                ReplaceWordStub("{Lc17}", tBLc17.Text, wordDocument);
                ReplaceWordStub("{Q1}", tBQ1.Text, wordDocument);
                ReplaceWordStub("{Q2}", tBQ2.Text, wordDocument);
                ReplaceWordStub("{Q3}", tBQ3.Text, wordDocument);
                ReplaceWordStub("{Q4}", tBQ4.Text, wordDocument);
                ReplaceWordStub("{Q5}", tBQ5.Text, wordDocument);
                ReplaceWordStub("{Q6}", tBQ6.Text, wordDocument);
                ReplaceWordStub("{Q7}", tBQ7.Text, wordDocument);
                ReplaceWordStub("{N1}", tBN1.Text, wordDocument);
                ReplaceWordStub("{N2}", tBN2.Text, wordDocument);
                ReplaceWordStub("{N3}", tBN3.Text, wordDocument);
                ReplaceWordStub("{N4}", tBN4.Text, wordDocument);
                ReplaceWordStub("{N5}", tBN5.Text, wordDocument);
                ReplaceWordStub("{N6}", tBN6.Text, wordDocument);
                ReplaceWordStub("{N7}", tBN7.Text, wordDocument);
                ReplaceWordStub("{R11}", tBR11.Text, wordDocument);
                ReplaceWordStub("{R12}", tBR12.Text, wordDocument);
                ReplaceWordStub("{R13}", tBR13.Text, wordDocument);
                ReplaceWordStub("{R14}", tBR14.Text, wordDocument);
                ReplaceWordStub("{R15}", tBR15.Text, wordDocument);
                ReplaceWordStub("{R16}", tBR16.Text, wordDocument);
                ReplaceWordStub("{R17}", tBR17.Text, wordDocument);
                ReplaceWordStub("{InterPlace}", comboBoxInterceptionPlace.Text, wordDocument);
                ReplaceWordStub("{numberOfLabWork}", Convert.ToString(flagOfLog), wordDocument);
                ReplaceWordStub("{Surname}", tBSurname.Text, wordDocument);
                ReplaceWordStub("{Na}", tBName.Text.Substring(0, 1), wordDocument);
                if (flagOfLog == 1)
                {
                    ReplaceWordStub("{Theme}", "«Оценка защищенности окон от утечки информации по акустическому и виброакустическому каналу»", wordDocument);
                }
                if (flagOfLog == 2)
                {
                    ReplaceWordStub("{Theme}", "«Оценка защищенности стен от утечки информации и оптимизация системы активной защиты по акустическому и виброакустическому каналу»", wordDocument);
                }
                if (flagOfLog == 3)
                {
                    ReplaceWordStub("{Theme}", "«Оценка защищенности дверей от утечки информации по акустическому и виброакустическому каналу»", wordDocument);
                }
                if (flagOfLog == 4)
                {
                    ReplaceWordStub("{Theme}", "«Оценка защищенности вентиляции от утечки информации и оптимизация системы активной защиты по акустическому и виброакустическому каналу»", wordDocument);
                }
                ReplaceWordStub("{P}", tBPatronymic.Text.Substring(0, 1), wordDocument);
                ReplaceWordStub("{group}", tBStudyGroup.Text, wordDocument);
                ReplaceWordStub("{mVPa11}", tBPovDatamVPa11.Text, wordDocument);
                ReplaceWordStub("{mVPa12}", tBPovDatamVPa12.Text, wordDocument);
                ReplaceWordStub("{mVPa13}", tBPovDatamVPa13.Text, wordDocument);
                ReplaceWordStub("{mVPa14}", tBPovDatamVPa14.Text, wordDocument);
                ReplaceWordStub("{mVPa15}", tBPovDatamVPa15.Text, wordDocument);
                ReplaceWordStub("{mVPa16}", tBPovDatamVPa16.Text, wordDocument);
                ReplaceWordStub("{mVPa17}", tBPovDatamVPa17.Text, wordDocument);
                ReplaceWordStub("{dB11}", tBPovDatadB11.Text, wordDocument);
                ReplaceWordStub("{dB12}", tBPovDatadB12.Text, wordDocument);
                ReplaceWordStub("{dB13}", tBPovDatadB13.Text, wordDocument);
                ReplaceWordStub("{dB14}", tBPovDatadB14.Text, wordDocument);
                ReplaceWordStub("{dB15}", tBPovDatadB15.Text, wordDocument);
                ReplaceWordStub("{dB16}", tBPovDatadB16.Text, wordDocument);
                ReplaceWordStub("{dB17}", tBPovDatadB17.Text, wordDocument);
                ReplaceWordStub("{mVPa21}", tBPovDatamVPa21.Text, wordDocument);
                ReplaceWordStub("{mVPa22}", tBPovDatamVPa22.Text, wordDocument);
                ReplaceWordStub("{mVPa23}", tBPovDatamVPa23.Text, wordDocument);
                ReplaceWordStub("{mVPa24}", tBPovDatamVPa24.Text, wordDocument);
                ReplaceWordStub("{mVPa25}", tBPovDatamVPa25.Text, wordDocument);
                ReplaceWordStub("{mVPa26}", tBPovDatamVPa26.Text, wordDocument);
                ReplaceWordStub("{mVPa27}", tBPovDatamVPa27.Text, wordDocument);
                ReplaceWordStub("{dB21}", tBPovDatadB21.Text, wordDocument);
                ReplaceWordStub("{dB22}", tBPovDatadB22.Text, wordDocument);
                ReplaceWordStub("{dB23}", tBPovDatadB23.Text, wordDocument);
                ReplaceWordStub("{dB24}", tBPovDatadB24.Text, wordDocument);
                ReplaceWordStub("{dB25}", tBPovDatadB25.Text, wordDocument);
                ReplaceWordStub("{dB26}", tBPovDatadB26.Text, wordDocument);
                ReplaceWordStub("{dB27}", tBPovDatadB27.Text, wordDocument);

                wordDocument.SaveAs(Environment.CurrentDirectory + "\\Отчет.docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Microsoft.Office.Interop.Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

        private void btnLogging2_Click(object sender, EventArgs e)
        {
            Logging(2);
        }

        private void btnLogging3_Click(object sender, EventArgs e)
        {
            Logging(3);
        }

        private void btnLogging4_Click(object sender, EventArgs e)
        {
            Logging(4);
        }

        private const string TopicLciHelp = "Lci(Vci).html";
        private void LciHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, TopicLciHelp);
        }

        private const string TopicAboutCP = "AboutCP.html";
        private void btnAboutCP_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, TopicAboutCP);
        }

        private const string TopicAboutPovDataAndSingalShum = "PovDataSignalShum.html";
        private void btnAboutPovDataAndSingalShum1_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, TopicAboutPovDataAndSingalShum);
        }

        private void btnAboutPovDataAndSingalShum2_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, TopicAboutPovDataAndSingalShum);
        }

        private const string Izmerenia = "Izmerenia.html";
        private void btnAboutIzmerenia1_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, Izmerenia);
        }

        private void btnAboutIzmerenia2_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, Izmerenia);
        }

        private const string LniHelp = "Lni.html";
        private void btnLniHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, LniHelp);
        }

        private const string DiHelp = "Di.html";
        private void btnDiHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, DiHelp);
        }

        private const string EiHelp = "Ei.html";
        private void btnEiHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, EiHelp);
        }

        private const string AiHelp = "Ai.html";
        private void btnAiHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, AiHelp);
        }

        private const string qiHelp = "qi.html";
        private void btnqiHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, qiHelp);
        }

        private const string piHelp = "pi.html";
        private void btnpiHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, piHelp);
        }

        private const string kiHelp = "ki.html";
        private void btnkiHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, kiHelp);
        }

        private const string riHelp = "ri.html";
        private void btnriHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, riHelp);
        }

        private const string ZashishennostHelp = "ZashishennostCP.html";
        private void btnZashishennostHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, ZashishennostHelp);
        }

        private const string ShorohHelp = "Shoroh.html";
        private void btnShorohHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, ShorohHelp);
        }

        private const string GraphicAndLoggingHelp = "GraphicAndLogging.html";
        private void btnGraphicAndLoggingHelp_Click(object sender, EventArgs e)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, @"Справка.chm", navigator, GraphicAndLoggingHelp);
        }

        private void btnLoadSignalShumFromDB_Click(object sender, EventArgs e)
        {
            db = new ShepotSim.ApplicationContext();
            List<SignalNoiseNormValue> snv = new List<SignalNoiseNormValue>();
            List<SignalNoiseNormValue> listSignalNoiseNormValue = db.SignalNoiseNormValues.ToList();
            foreach (SignalNoiseNormValue snval in listSignalNoiseNormValue)
            {
                snv.Add(snval);
            }
            for (int i = 0; i < NormMeas.Count; i++)
            {
                NormMeas[i].Text = Convert.ToString(snv[i].NormValue);
            }
        }
    }
}
