using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneCallers.caller;
using PhoneCallers.cfg;
using PhoneCallers.proxy;
using PhoneCallers.request;
using PhoneCallers.request.textPreprocessors;

namespace PhoneCallers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public PhoneCaller phoneCaller;

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateEmptyCfg();
            //phoneCaller = CfgLoader.Load<PhoneCaller>("phone_caller.cfg");
        }



        private void CreateEmptyCfg()
        {
            phoneCaller = new PhoneCaller(
                new ProxyPool()
                {
                    Proxies = new List<Proxy>() { new Proxy() }
                },
                new RequestGenerator()
                {
                    PhonePreprocessor = new PhonePreprocessor(),
                    Preprocessors = new List<Preprocessor>() { new NamePreprocessor(), new RandomNumberPreprocessor() }
                }
               ,
                new RequestTemplatesPool() { RequestTemplates = new List<RequestTemplate>() { new RequestTemplate(), new RequestTemplate() } }

                );
            CfgLoader.Save("phone_caller.xml", phoneCaller);
        }
    }
}
