using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;



namespace BaminOrderRelation
{
    public partial class FrmBaminOrderRelationMain : Form
    {
        const int S_OK = 0;
        const int PT_PREPAYED = 0;
        const int PT_MEET_CARD = 1;
        const int PT_MEET_CASH = 2;

        const int OS_NEW = 0;
        const int OS_RECEIPT = 1;
        const int OS_COMPLETED = 2;
        const int OS_CANCELED = 3;

        const int DS_RIDER_ASSIGNED = 0;
        const int DS_PICKUP_COMPLETED = 1;
        const int DS_DELIVERY_COMPLETED = 2;


        public delegate bool TOnNewDeliveryFunc([MarshalAs(UnmanagedType.LPWStr)] string AOrderNo, [MarshalAs(UnmanagedType.LPWStr)] string ARoadNameAddress,
            [MarshalAs(UnmanagedType.LPWStr)] string AAddress, [MarshalAs(UnmanagedType.LPWStr)] string AAddressDetail, [MarshalAs(UnmanagedType.LPWStr)] string APhoneNo,
            [MarshalAs(UnmanagedType.LPWStr)] string ALatitude, [MarshalAs(UnmanagedType.LPWStr)] string ALongitude, [MarshalAs(UnmanagedType.LPWStr)] string ATitle,
            int AQuantity, int AAmount, int APaymentType, [MarshalAs(UnmanagedType.LPWStr)] string AMemo);
        public delegate void TOnStatusChangedProc([MarshalAs(UnmanagedType.LPWStr)] string AOrderNo, int AOrderStatus);
        public delegate void TOnDisconnectedProc();
        
        public TOnNewDeliveryFunc s_newDeliveryFunc;
        public TOnStatusChangedProc s_statusChangedProc;
        public TOnDisconnectedProc s_disconnectedProc;

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "InitializeService", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int InitializeService64(string ASignKey);

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "FinalizeService", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int FinalizeService64();

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "RegisterNewDeliveryFunction", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterNewDeliveryFunction64(TOnNewDeliveryFunc AEvent);

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "RegisterStatusChangedFunction", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterStatusChangedFunction64(TOnStatusChangedProc AEvent);

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "RegisterDisconnectedFunction", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterDisconnectedFunction64(TOnDisconnectedProc AEvent);

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "SetDeliveryCompleted", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDeliveryCompleted64(string AOrderNo);

        [DllImport("BMOrderRelayx64.dll", EntryPoint = "UpdateDeliveryStatus", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateDeliveryStatus64(string AOrderNo, int ADeliveryStatus, string ARiderKey, string ARiderName, int ETA);

        [DllImport("BMOrderRelay.dll", EntryPoint = "InitializeService", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int InitializeService32(string ASignKey);

        [DllImport("BMOrderRelay.dll", EntryPoint = "FinalizeService", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int FinalizeService32();

        [DllImport("BMOrderRelay.dll", EntryPoint = "RegisterNewDeliveryFunction", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterNewDeliveryFunction32(TOnNewDeliveryFunc AEvent);

        [DllImport("BMOrderRelay.dll", EntryPoint = "RegisterStatusChangedFunction", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterStatusChangedFunction32(TOnStatusChangedProc AEvent);

        [DllImport("BMOrderRelay.dll", EntryPoint = "RegisterDisconnectedFunction", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool RegisterDisconnectedFunction32(TOnDisconnectedProc AEvent);

        [DllImport("BMOrderRelay.dll", EntryPoint = "SetDeliveryCompleted", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetDeliveryCompleted32(string AOrderNo);

        [DllImport("BMOrderRelay.dll", EntryPoint = "UpdateDeliveryStatus", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool UpdateDeliveryStatus32(string AOrderNo, int ADeliveryStatus, string ARiderKey, string ARiderName, int ETA);

        public static int InitializeService(string ASignKey)
        {
            return Environment.Is64BitOperatingSystem ? InitializeService64(ASignKey) : InitializeService32(ASignKey);
        }

        public static int FinalizeService()
        {
            return Environment.Is64BitOperatingSystem ? FinalizeService64() : FinalizeService32();
        }

        public static bool RegisterNewDeliveryFunction(TOnNewDeliveryFunc AEvent)
        {
            return Environment.Is64BitOperatingSystem ? RegisterNewDeliveryFunction64(AEvent) : RegisterNewDeliveryFunction32(AEvent);
        }

        public static bool RegisterStatusChangedFunction(TOnStatusChangedProc AEvent)
        {
            return Environment.Is64BitOperatingSystem ? RegisterStatusChangedFunction64(AEvent) : RegisterStatusChangedFunction32(AEvent);
        }

        public static bool RegisterDisconnectedFunction(TOnDisconnectedProc AEvent)
        {
            return Environment.Is64BitOperatingSystem ? RegisterDisconnectedFunction64(AEvent) : RegisterDisconnectedFunction32(AEvent);
        }

        [Obsolete("SetDeliveryCompleted is deprecated, please use UpdateDeliveryStatus instead.")]
        public static bool SetDeliveryCompleted(string AOrderNo)
        {
            return Environment.Is64BitOperatingSystem ? SetDeliveryCompleted64(AOrderNo) : SetDeliveryCompleted32(AOrderNo);
        }

        public static bool UpdateDeliveryStatus(string AOrderNo, int ADeliveryStatus, string ARiderKey, string ARiderName, int ETA)
        {
            return Environment.Is64BitOperatingSystem ? UpdateDeliveryStatus64(AOrderNo, ADeliveryStatus, ARiderKey, ARiderName, ETA) : UpdateDeliveryStatus32(AOrderNo, ADeliveryStatus, ARiderKey, ARiderName, ETA);
        }

        public FrmBaminOrderRelationMain()
        {
            InitializeComponent();

            s_newDeliveryFunc = this.MyOnNewDeliveryFunc;
            s_statusChangedProc = this.MyOnStatusChangedProc;
            s_disconnectedProc = this.MyOnDisconnectedProc;
        }

        private void btnInitializeService_Click(object sender, EventArgs e)
        {
            if (InitializeService("hJTk2rWrfc6C1UEmk9Uvc2MGpUuOpEw3q8i1/4+EUcFObqlNhzCvVHFM") != S_OK) {
                MessageBox.Show("InitializeService Failed");
            }
            richTextBox1.AppendText("Initialize Service" + Environment.NewLine);
        }

        private void btnFinalizeService_Click(object sender, EventArgs e)
        {
            if (FinalizeService() != S_OK)
            {
                MessageBox.Show("FinalizeService Failed");
            }
            richTextBox1.AppendText("Finalize Service" + Environment.NewLine);
        }

        private void btnRegCallback_Click(object sender, EventArgs e)
        {
            if (!RegisterNewDeliveryFunction(s_newDeliveryFunc))
                MessageBox.Show("Error RegisterNewDeliveryFunction!");
            if (!RegisterStatusChangedFunction(s_statusChangedProc))
                MessageBox.Show("Error RegisterStatusChangedFunction!");
            if (!RegisterDisconnectedFunction(s_disconnectedProc))
                MessageBox.Show("Error RegisterDisconnectedFunction");
            richTextBox1.AppendText("Register Callback Functions" + Environment.NewLine);
        }
         
        private bool MyOnNewDeliveryFunc(string AOrderNo, string ARoadNameAddress, string AAddress, string AAddressDetail, string APhoneNo,
            string ALatitude, string ALongitude, string ATitle, int AQuantity, int AAmount, int APaymentType, string AMemo)
        {
            //MessageBox.Show("AOrderNo:" + AOrderNo);
            Invoke(new MethodInvoker(delegate ()
            {
                richTextBox1.AppendText("[New Delivery]" + Environment.NewLine);
                richTextBox1.AppendText("AOrderNo: " + AOrderNo + Environment.NewLine);
                richTextBox1.AppendText("ARoadNameAddress: " + ARoadNameAddress + Environment.NewLine);
                richTextBox1.AppendText("AAddress: " + AAddress + Environment.NewLine);
                richTextBox1.AppendText("AAddressDetail: " + AAddressDetail + Environment.NewLine);
                richTextBox1.AppendText("APhoneNo: " + APhoneNo + Environment.NewLine);
                richTextBox1.AppendText("ALatitude: " + ALatitude + Environment.NewLine);
                richTextBox1.AppendText("ALongitude: " + ALongitude + Environment.NewLine);
                richTextBox1.AppendText("ATitle: " + ATitle + Environment.NewLine);
                richTextBox1.AppendText("AQuantity: " + AQuantity + Environment.NewLine);
                richTextBox1.AppendText("AAmount: " + AAmount + Environment.NewLine);
                richTextBox1.AppendText("AMemo: " + AMemo + Environment.NewLine);
                switch (APaymentType)
                {
                    case PT_PREPAYED:
                        richTextBox1.AppendText("PaymentType: 바로결제" + Environment.NewLine);
                        break;
                    case PT_MEET_CARD:
                        richTextBox1.AppendText("PaymentType: 만나서 결제 카드" + Environment.NewLine);
                        break;
                    case PT_MEET_CASH:
                        richTextBox1.AppendText("PaymentType: 만나서 결제 현금" + Environment.NewLine);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }


                Form2 addDelivery = new Form2();
                addDelivery.tbOrderNo.Text = AOrderNo;
                addDelivery.tbRoadName.Text = ARoadNameAddress;
                addDelivery.tbAddress.Text = AAddress;
                addDelivery.tbAddressDetail.Text = AAddressDetail;
                addDelivery.tbPhoneNo.Text = APhoneNo;
                addDelivery.tbLatitude.Text = ALatitude;
                addDelivery.tbLongitude.Text = ALongitude;
                addDelivery.tbTitle.Text = ATitle;
                addDelivery.tbTotalAmount.Text = AAmount.ToString();
                addDelivery.tbTotalCount.Text = AQuantity.ToString();

                switch (APaymentType)
                {
                    case PT_PREPAYED:
                        addDelivery.rbPrepaid.Checked = true;
                        break;
                    case PT_MEET_CARD:
                        addDelivery.rbMeetCard.Checked = true;
                        break;
                    case PT_MEET_CASH:
                        addDelivery.rbMeetCash.Checked = true;
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }


                DialogResult Res = addDelivery.ShowDialog(this);
                if (Res == DialogResult.OK)
                {
                    ListViewItem item = new ListViewItem(AOrderNo);
                    item.SubItems.Add(ARoadNameAddress + " " + AAddressDetail);
                    item.SubItems.Add(ALatitude + ", " + ALongitude);
                    if (addDelivery.rbPrepaid.Checked)
                        item.SubItems.Add("바로결제");
                    else if (addDelivery.rbMeetCard.Checked)
                        item.SubItems.Add("만나서 결제 카드");
                    else
                        item.SubItems.Add("만나서 결제 현금");
                    //item.SubItems.Add(ARoadNameAddress + " " + AAddressDetail);

                    listView1.Items.Add(item);
                }
            }));
            return true;

        }

        private void MyOnStatusChangedProc(string AOrderNo, int AOrderStatus)
        {
            Invoke(new MethodInvoker(delegate () 
            {
                richTextBox1.AppendText("StatusChanged: " + AOrderNo + " " + AOrderStatus + Environment.NewLine);

                for (int i = listView1.Items.Count-1; i >=0 ; i--)
                {
                    if (AOrderNo.Equals(listView1.Items[i].Text)) {
                        listView1.Items.RemoveAt(i);
                        break;
                    }
                }

            }));
        }

        private void MyOnDisconnectedProc()
        {
            Invoke(new MethodInvoker(delegate () { richTextBox1.AppendText("Disconnected!!!" + Environment.NewLine); }));
        }

        private void btnUpdateDeliveryStatus_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)
            {
                return;
            }
            int intselectedindex = listView1.SelectedIndices[0];
            if (intselectedindex >= 0)
            {
                Form3 changeRiderStatus = new Form3();
                

                String text = listView1.Items[intselectedindex].Text;
                changeRiderStatus.tbOrderNo.Text = text;

                DialogResult Res = changeRiderStatus.ShowDialog(this);
                if (Res == DialogResult.OK)
                {
                    int DeliveryStatus = DS_RIDER_ASSIGNED;
                    if (changeRiderStatus.rbRiderAssigned.Checked == true)
                        DeliveryStatus = DS_RIDER_ASSIGNED;
                    else if (changeRiderStatus.rbPickupCompleted.Checked == true)
                        DeliveryStatus = DS_PICKUP_COMPLETED;
                    else if (changeRiderStatus.rbDeliveryCompleted.Checked == true)
                        DeliveryStatus = DS_DELIVERY_COMPLETED;

                    UpdateDeliveryStatus(changeRiderStatus.tbOrderNo.Text, DeliveryStatus, changeRiderStatus.tbRiderCode.Text, changeRiderStatus.tbRiderName.Text, Convert.ToInt32(changeRiderStatus.tbETA.Text));
                }

            }
        }
    }
}
