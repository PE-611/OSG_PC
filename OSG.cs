using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;


namespace Test_COM
{
    public partial class OSG : Form
    {   
 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №1 /////////////////////////////////////////////////////////////////////////////////////////// 
       
        int DurationPulseCH1;                        // Переменная для хранения числового значения длительности импульса
        int DelBetweenPulseCH1;                      // Переменная для хранения числового значения паузы между импульсами
        byte[] DurationMassiveDataCH1;               // Массив хранящий две части переменной int DurationPulse в формате byte
        byte[] DelayMassiveDataCH1;                  // Массив хранящий две части переменной int DelayMassiveData в формате byte
        byte DurMultiplierCH1;                       // Переменная хранит закодированное значение множителя для задания диапазона (нс, мкс, мс с) длительности импульса 
        byte DelMultiplierCH1;                       // Переменная хранит закодированное значение множителя для задания диапазона (нс, мкс, мс с) длительности импульса 
        byte TypeStartCH1;                           // Переменная хранит код типа запуска (общий или последовательный) 

 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №2 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH2;                        
        int DelBetweenPulseCH2;                      
        byte[] DurationMassiveDataCH2;               
        byte[] DelayMassiveDataCH2;                  
        byte DurMultiplierCH2;                        
        byte DelMultiplierCH2;                        
        byte TypeStartCH2;

 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №3 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH3;
        int DelBetweenPulseCH3;
        byte[] DurationMassiveDataCH3;
        byte[] DelayMassiveDataCH3;
        byte DurMultiplierCH3;
        byte DelMultiplierCH3;
        byte TypeStartCH3;

//////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №4 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH4;
        int DelBetweenPulseCH4;
        byte[] DurationMassiveDataCH4;
        byte[] DelayMassiveDataCH4;
        byte DurMultiplierCH4;
        byte DelMultiplierCH4;
        byte TypeStartCH4;

 //////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №5 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH5;
        int DelBetweenPulseCH5;
        byte[] DurationMassiveDataCH5;
        byte[] DelayMassiveDataCH5;
        byte DurMultiplierCH5;
        byte DelMultiplierCH5;
        byte TypeStartCH5;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №6 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH6;
        int DelBetweenPulseCH6;
        byte[] DurationMassiveDataCH6;
        byte[] DelayMassiveDataCH6;
        byte DurMultiplierCH6;
        byte DelMultiplierCH6;
        byte TypeStartCH6;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №7 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH7;
        int DelBetweenPulseCH7;
        byte[] DurationMassiveDataCH7;
        byte[] DelayMassiveDataCH7;
        byte DurMultiplierCH7;
        byte DelMultiplierCH7;
        byte TypeStartCH7;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №8 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH8;
        int DelBetweenPulseCH8;
        byte[] DurationMassiveDataCH8;
        byte[] DelayMassiveDataCH8;
        byte DurMultiplierCH8;
        byte DelMultiplierCH8;
        byte TypeStartCH8;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №9 /////////////////////////////////////////////////////////////////////////////////////////// 
        int DurationPulseCH9;                        
        int DelBetweenPulseCH9;                      
        byte[] DurationMassiveDataCH9;               
        byte[] DelayMassiveDataCH9;                  
        byte DurMultiplierCH9;                       
        byte DelMultiplierCH9;                       
        byte TypeStartCH9;

////////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №10 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH10;
        int DelBetweenPulseCH10;
        byte[] DurationMassiveDataCH10;
        byte[] DelayMassiveDataCH10;
        byte DurMultiplierCH10;
        byte DelMultiplierCH10;
        byte TypeStartCH10;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №11 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH11;
        int DelBetweenPulseCH11;
        byte[] DurationMassiveDataCH11;
        byte[] DelayMassiveDataCH11;
        byte DurMultiplierCH11;
        byte DelMultiplierCH11;
        byte TypeStartCH11;

///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №12 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH12;
        int DelBetweenPulseCH12;
        byte[] DurationMassiveDataCH12;
        byte[] DelayMassiveDataCH12;
        byte DurMultiplierCH12;
        byte DelMultiplierCH12;
        byte TypeStartCH12;

 ///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №13 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH13;
        int DelBetweenPulseCH13;
        byte[] DurationMassiveDataCH13;
        byte[] DelayMassiveDataCH13;
        byte DurMultiplierCH13;
        byte DelMultiplierCH13;
        byte TypeStartCH13;

////////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №14 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH14;
        int DelBetweenPulseCH14;
        byte[] DurationMassiveDataCH14;
        byte[] DelayMassiveDataCH14;
        byte DurMultiplierCH14;
        byte DelMultiplierCH14;
        byte TypeStartCH14;

 ///////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №15 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH15;
        int DelBetweenPulseCH15;
        byte[] DurationMassiveDataCH15;
        byte[] DelayMassiveDataCH15;
        byte DurMultiplierCH15;
        byte DelMultiplierCH15;
        byte TypeStartCH15;

////////////////////////////////////////////////////// ПЕРЕМЕННЫЕ ДЛЯ КАНАЛА №16 ///////////////////////////////////////////////////////////////////////////////////////////

        int DurationPulseCH16;
        int DelBetweenPulseCH16;
        byte[] DurationMassiveDataCH16;
        byte[] DelayMassiveDataCH16;
        byte DurMultiplierCH16;
        byte DelMultiplierCH16;
        byte TypeStartCH16;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////// Инициализация GUI и СОМ ПОРТА ///////////////////////////////////////////////////////////////////////////////////////

        public OSG()
        {
            InitializeComponent();              

            string[] ports;                       // Массив строковых переменных для хранения имен подключеннх СОМ портов
            ports = SerialPort.GetPortNames();    // Получение имен подключеннх СОМ портов
            ComComboBox.Items.AddRange(ports);    // Добавление полученных имен СОМ портов в  СОМ комбобокс


            DurTextBoxCh1.Text = "0";             // Начальное значение длительности канала №1
            DelTextBoxch1.Text = "0";             // Начальное значение паузы канала №1
           
            DurTextBoxCh2.Text = "0";             
            DelTextBoxch2.Text = "0";

            DurTextBoxCh3.Text = "0";
            DelTextBoxch3.Text = "0";

            DurTextBoxCh4.Text = "0";
            DelTextBoxch4.Text = "0";

            DurTextBoxCh5.Text = "0";
            DelTextBoxch5.Text = "0";

            DurTextBoxCh6.Text = "0";
            DelTextBoxch6.Text = "0";

            DurTextBoxCh7.Text = "0";
            DelTextBoxch7.Text = "0";

            DurTextBoxCh8.Text = "0";
            DelTextBoxch8.Text = "0";

            DurTextBoxCh9.Text = "0";
            DelTextBoxch9.Text = "0";

            DurTextBoxCh10.Text = "0";
            DelTextBoxch10.Text = "0";

            DurTextBoxCh11.Text = "0";
            DelTextBoxch11.Text = "0";

            DurTextBoxCh12.Text = "0";
            DelTextBoxch12.Text = "0";

            DurTextBoxCh13.Text = "0";
            DelTextBoxch13.Text = "0";

            DurTextBoxCh14.Text = "0";
            DelTextBoxch14.Text = "0";

            DurTextBoxCh15.Text = "0";
            DelTextBoxch15.Text = "0";

            DurTextBoxCh16.Text = "0";
            DelTextBoxch16.Text = "0";

            
        }



        SerialPort Port = new SerialPort("COM", 115200, Parity.None, 8, StopBits.One);            // Инициализация последовательного порта 
        // _serialPort.Handshake = Handshake.None;

        public void ComComboBox_SelectedIndexChanged(object sender, EventArgs e)                // При выборе СОМ порта осуществляем:
        {
            if (Port.IsOpen == false)
            {
                Port.PortName = ComComboBox.Text.ToString();                                    // Изменение имени Комбобокса
                Port.Open();                                                                    // Открываем порт
                Port.BaudRate = 115200;
                //Port.WriteTimeout = 1000;                                                       // Эти тайм ауты можно не ставить
                //Port.ReadTimeout = 1000;                                                        // Эти тайм ауты можно не ставить
                OffComButton.Text = "Отключить " + Port.PortName;                               // Изменяем текст на кнопке отключения порта на "Отключить СОМ порт"
                label1.Text = "Подключен";                                                      // Изменяем текст на лейбле на "Подключен"    
                pictureBox1.BackColor = Color.LightGreen;                                       // Зажигаем зеленым лампочку оповещающую о подключенном СОМ порте
            }
        }

        public void OffComButton_Click(object sender, EventArgs e)                              // При нажатии на кнопку отключения СОМ порта осуществяем:
        {
            Port.Close();                                                                       // Закрываем порт
            OffComButton.Text = "Выберите порт";                                                // Изменяем текст на кнопке отключения порта на "Выберите порт"
            label1.Text = "Нет подключенных портов";                                            // Изменяем текст на лейбле на "Нет подключенных портов"
            ComComboBox.Text = "";                                                              // Очищаем СОМ комбобокс
            pictureBox1.BackColor = Color.Empty;                                                // Цвет "лампочки" фоновый
        }
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


////////////////////////////////////////////////// Организация GUI, пакета данных для передачи в СОМ порт и передача данных ///////////////////////////////////////////////////////////////

        public void SerialSendButton_Click(object sender, EventArgs e)                          // При нажатии на кнопку отправки в СОМ порт:
        {
            int count = 112;              ///// ВНИМАНИЕ                                          // Количество байтов массива для отправки в СОМ 
            int offset = 0;                                                                     // Смещение не нужно = 0
            byte[] buffer = new byte[] {DurationMassiveDataCH1[0], DurationMassiveDataCH1[1],   // Массив байтов для отправки в СОМ порт
                                        DelayMassiveDataCH1[0],    DelayMassiveDataCH1[1],
                                        DurMultiplierCH1,          DelMultiplierCH1,
                                        TypeStartCH1,

                                        DurationMassiveDataCH2[0], DurationMassiveDataCH2[1],   
                                        DelayMassiveDataCH2[0],    DelayMassiveDataCH2[1],
                                        DurMultiplierCH2,          DelMultiplierCH2,
                                        TypeStartCH2,

                                        DurationMassiveDataCH3[0], DurationMassiveDataCH3[1],
                                        DelayMassiveDataCH3[0],    DelayMassiveDataCH3[1],
                                        DurMultiplierCH3,          DelMultiplierCH3,
                                        TypeStartCH3,

                                        DurationMassiveDataCH4[0], DurationMassiveDataCH4[1],
                                        DelayMassiveDataCH4[0],    DelayMassiveDataCH4[1],
                                        DurMultiplierCH4,          DelMultiplierCH4,
                                        TypeStartCH4,

                                        DurationMassiveDataCH5[0], DurationMassiveDataCH5[1],
                                        DelayMassiveDataCH5[0],    DelayMassiveDataCH5[1],
                                        DurMultiplierCH5,          DelMultiplierCH5,
                                        TypeStartCH5,

                                        DurationMassiveDataCH6[0], DurationMassiveDataCH6[1],
                                        DelayMassiveDataCH6[0],    DelayMassiveDataCH6[1],
                                        DurMultiplierCH6,          DelMultiplierCH6,
                                        TypeStartCH6,

                                        DurationMassiveDataCH7[0], DurationMassiveDataCH7[1],
                                        DelayMassiveDataCH7[0],    DelayMassiveDataCH7[1],
                                        DurMultiplierCH7,          DelMultiplierCH7,
                                        TypeStartCH7,

                                        DurationMassiveDataCH8[0], DurationMassiveDataCH8[1],
                                        DelayMassiveDataCH8[0],    DelayMassiveDataCH8[1],
                                        DurMultiplierCH8,          DelMultiplierCH8,
                                        TypeStartCH8,

                                        DurationMassiveDataCH9[0], DurationMassiveDataCH9[1],   
                                        DelayMassiveDataCH9[0],    DelayMassiveDataCH9[1],
                                        DurMultiplierCH9,          DelMultiplierCH9,
                                        TypeStartCH9,

                                        DurationMassiveDataCH10[0], DurationMassiveDataCH10[1],
                                        DelayMassiveDataCH10[0],    DelayMassiveDataCH10[1],
                                        DurMultiplierCH10,          DelMultiplierCH10,
                                        TypeStartCH10,

                                        DurationMassiveDataCH11[0], DurationMassiveDataCH11[1],
                                        DelayMassiveDataCH11[0],    DelayMassiveDataCH11[1],
                                        DurMultiplierCH11,          DelMultiplierCH11,
                                        TypeStartCH11,

                                        DurationMassiveDataCH12[0], DurationMassiveDataCH12[1],
                                        DelayMassiveDataCH12[0],    DelayMassiveDataCH12[1],
                                        DurMultiplierCH12,          DelMultiplierCH12,
                                        TypeStartCH12,

                                        DurationMassiveDataCH13[0], DurationMassiveDataCH13[1],
                                        DelayMassiveDataCH13[0],    DelayMassiveDataCH13[1],
                                        DurMultiplierCH13,          DelMultiplierCH13,
                                        TypeStartCH13,

                                        DurationMassiveDataCH14[0], DurationMassiveDataCH14[1],
                                        DelayMassiveDataCH14[0],    DelayMassiveDataCH14[1],
                                        DurMultiplierCH14,          DelMultiplierCH14,
                                        TypeStartCH14,

                                        DurationMassiveDataCH15[0], DurationMassiveDataCH15[1],
                                        DelayMassiveDataCH15[0],    DelayMassiveDataCH15[1],
                                        DurMultiplierCH15,          DelMultiplierCH15,
                                        TypeStartCH15,

                                        DurationMassiveDataCH16[0], DurationMassiveDataCH16[1],
                                        DelayMassiveDataCH16[0],    DelayMassiveDataCH16[1],
                                        DurMultiplierCH16,          DelMultiplierCH16,
                                        TypeStartCH16
                                                                                     };

            if (Port.IsOpen == true)                                                            // Если порт открыт 
            {
                if (DurTextBoxCh1.Text == "255" | DelTextBoxch1.Text == "255" | DurTextBoxCh2.Text == "255" | DelTextBoxch2.Text == "255"
                  | DurTextBoxCh3.Text == "255" | DelTextBoxch3.Text == "255" | DurTextBoxCh4.Text == "255" | DelTextBoxch4.Text == "255"
                  | DurTextBoxCh5.Text == "255" | DelTextBoxch5.Text == "255" | DurTextBoxCh6.Text == "255" | DelTextBoxch6.Text == "255"
                  | DurTextBoxCh7.Text == "255" | DelTextBoxch7.Text == "255" | DurTextBoxCh8.Text == "255" | DelTextBoxch8.Text == "255"
                  | DurTextBoxCh9.Text == "255" | DelTextBoxch9.Text == "255" | DurTextBoxCh10.Text == "255" | DelTextBoxch10.Text == "255"
                  | DurTextBoxCh11.Text == "255" | DelTextBoxch11.Text == "255" | DurTextBoxCh12.Text == "255" | DelTextBoxch12.Text == "255"
                  | DurTextBoxCh13.Text == "255" | DelTextBoxch13.Text == "255" | DurTextBoxCh14.Text == "255" | DelTextBoxch14.Text == "255"
                  | DurTextBoxCh15.Text == "255" | DelTextBoxch15.Text == "255" | DurTextBoxCh16.Text == "255" | DelTextBoxch16.Text == "255"
                  
                  | DurTextBoxCh1.Text == "511" | DelTextBoxch1.Text == "511" | DurTextBoxCh2.Text == "511" | DelTextBoxch2.Text == "511"
                  | DurTextBoxCh3.Text == "511" | DelTextBoxch3.Text == "511" | DurTextBoxCh4.Text == "511" | DelTextBoxch4.Text == "511"
                  | DurTextBoxCh5.Text == "511" | DelTextBoxch5.Text == "511" | DurTextBoxCh6.Text == "511" | DelTextBoxch6.Text == "511"
                  | DurTextBoxCh7.Text == "511" | DelTextBoxch7.Text == "511" | DurTextBoxCh8.Text == "511" | DelTextBoxch8.Text == "511"
                  | DurTextBoxCh9.Text == "511" | DelTextBoxch9.Text == "511" | DurTextBoxCh10.Text == "511" | DelTextBoxch10.Text == "511"
                  | DurTextBoxCh11.Text == "511" | DelTextBoxch11.Text == "511" | DurTextBoxCh12.Text == "511" | DelTextBoxch12.Text == "511"  ////////// КОСТЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫЫЛь
                  | DurTextBoxCh13.Text == "511" | DelTextBoxch13.Text == "511" | DurTextBoxCh14.Text == "511" | DelTextBoxch14.Text == "511"
                  | DurTextBoxCh15.Text == "511" | DelTextBoxch15.Text == "511" | DurTextBoxCh16.Text == "511" | DelTextBoxch16.Text == "511"

                  | DurTextBoxCh1.Text == "767" | DelTextBoxch1.Text == "767" | DurTextBoxCh2.Text == "767" | DelTextBoxch2.Text == "767"
                  | DurTextBoxCh3.Text == "767" | DelTextBoxch3.Text == "767" | DurTextBoxCh4.Text == "767" | DelTextBoxch4.Text == "767"
                  | DurTextBoxCh5.Text == "767" | DelTextBoxch5.Text == "767" | DurTextBoxCh6.Text == "767" | DelTextBoxch6.Text == "767"
                  | DurTextBoxCh7.Text == "767" | DelTextBoxch7.Text == "767" | DurTextBoxCh8.Text == "767" | DelTextBoxch8.Text == "767"
                  | DurTextBoxCh9.Text == "767" | DelTextBoxch9.Text == "767" | DurTextBoxCh10.Text == "767" | DelTextBoxch10.Text == "767"
                  | DurTextBoxCh11.Text == "767" | DelTextBoxch11.Text == "767" | DurTextBoxCh12.Text == "767" | DelTextBoxch12.Text == "767"
                  | DurTextBoxCh13.Text == "767" | DelTextBoxch13.Text == "767" | DurTextBoxCh14.Text == "767" | DelTextBoxch14.Text == "767"
                  | DurTextBoxCh15.Text == "767" | DelTextBoxch15.Text == "767" | DurTextBoxCh16.Text == "767" | DelTextBoxch16.Text == "767")
                
                {
                        MessageBox.Show("Введите значение отличающееся от 255", "Сообщение",               // Выводим сообщение призывающее выбрать СОМ порт
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                     // MessageBoxOptions.ServiceNotification);
                }
                else                                                                            // Теперь проверяем выбор типа пуска
                {                                                                               // Если хоть один из пусков не выбран то 
                    if (ComboBoxTypeStartCh1.Text == "" | ComboBoxTypeStartCh2.Text == "" | ComboBoxTypeStartCh3.Text == "" | ComboBoxTypeStartCh4.Text == "" 
                      | ComboBoxTypeStartCh5.Text == "" | ComboBoxTypeStartCh6.Text == "" | ComboBoxTypeStartCh7.Text == "" | ComboBoxTypeStartCh8.Text == ""
                      | ComboBoxTypeStartCh9.Text == "" | ComboBoxTypeStartCh10.Text == "" | ComboBoxTypeStartCh11.Text == "" | ComboBoxTypeStartCh12.Text == ""
                      | ComboBoxTypeStartCh13.Text == "" | ComboBoxTypeStartCh14.Text == "" | ComboBoxTypeStartCh15.Text == "" | ComboBoxTypeStartCh16.Text == "")
                    {
                        MessageBox.Show("Выберите тип пуска", "Сообщение",                      // Выводим сообщение призывающее выбрать тип пуска
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        // MessageBoxOptions.ServiceNotification);

                    }
                    else
                    {                                                                           // Если текст боксы пустые выводим сообщение призывающее выбрать диапазон
                        if (DurComboBoxCh1.Text == "" | DelComboBoxCh1.Text == "" | DurComboBoxCh2.Text == "" | DelComboBoxCh2.Text == "" 
                          | DurComboBoxCh3.Text == "" | DelComboBoxCh3.Text == "" | DurComboBoxCh4.Text == "" | DelComboBoxCh4.Text == ""
                          | DurComboBoxCh5.Text == "" | DelComboBoxCh5.Text == "" | DurComboBoxCh6.Text == "" | DelComboBoxCh6.Text == ""
                          | DurComboBoxCh7.Text == "" | DelComboBoxCh7.Text == "" | DurComboBoxCh8.Text == "" | DelComboBoxCh8.Text == ""
                          | DurComboBoxCh9.Text == "" | DelComboBoxCh9.Text == "" | DurComboBoxCh10.Text == "" | DelComboBoxCh10.Text == ""
                          | DurComboBoxCh11.Text == "" | DelComboBoxCh11.Text == "" | DurComboBoxCh12.Text == "" | DelComboBoxCh12.Text == ""
                          | DurComboBoxCh13.Text == "" | DelComboBoxCh13.Text == "" | DurComboBoxCh14.Text == "" | DelComboBoxCh14.Text == ""
                          | DurComboBoxCh15.Text == "" | DelComboBoxCh15.Text == "" | DurComboBoxCh16.Text == "" | DelComboBoxCh16.Text == "")             
                        {
                            MessageBox.Show("Выберите диапазон длительности и задержки 'нс','мкс','мс','с'", "Сообщение",  
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            
                            Port.Write(buffer, offset, count);                                  // Осуществляем передачу байтов
                            //SerialSendButton.Click -= new System.EventHandler(this.SerialSendButton_Click);
                            //SerialSendButton.Enabled = false;
                            //Thread.Sleep(500);
                            //SerialSendButton.Enabled = true;
                            //SerialSendButton.Click += new System.EventHandler(SerialSendButton_Click);



                        }
                    }
                }
                
            }
            if (Port.IsOpen == false)                                                           // Если порт закрыт (а закрыт он может быть только потому что мы его не выбрали в СОМ комбобоксе)
            {                                                                       
                MessageBox.Show("Выберите СОМ порт", "Сообщение",                               // Выводим сообщение призывающее выбрать СОМ порт
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                 // MessageBoxOptions.ServiceNotification);
            }
        }

        public void StartButton_Click(object sender, EventArgs e)
        {
            int count = 1;
            int offset = 0;
            byte[] BufStart = new byte[] { 255 };                                                             // Какое число отправлять в качестве сигнала на ПУСК???  !!!ответ 255!!!

            if (Port.IsOpen == true)                                                            // Если порт открыт 
            {
                
                if (DurTextBoxCh1.Text == "0" | DelTextBoxch1.Text == "0")                                  
                {
                    MessageBox.Show("Введите значение больше 0", "Сообщение",                   // Выводим сообщение призывающее ввести значение больше 0
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                    // MessageBoxOptions.ServiceNotification);
                }
                else
                {
                    if (ComboBoxTypeStartCh1.Text == "")
                    {
                        MessageBox.Show("Выберите тип пуска", "Сообщение",                      // Выводим сообщение призывающее выбрать тип пуска
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                        // MessageBoxOptions.ServiceNotification);

                    }
                    else
                    {
                        if (DurComboBoxCh1.Text == "" | DelComboBoxCh1.Text == "")
                        {
                            MessageBox.Show("Выберите диапазон длительности и задержки 'нс','мкс','мс','с'", "Сообщение",    // Выводим сообщение призывающее выбрать тип пуска
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            Port.Write(BufStart, offset, count);
                            //StartButton.Click -= new System.EventHandler(this.StartButton_Click);
                            ///StartButton.Enabled = false;
                            //Thread.Sleep(500);
                            //StartButton.Enabled = true;
                           // StartButton.Click += new System.EventHandler(StartButton_Click);




                        }

                    }

                }
            }

            if (Port.IsOpen == false)
            {
                MessageBox.Show("Выберите СОМ порт", "Сообщение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                 // MessageBoxOptions.ServiceNotification);
            }

        }
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №1      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh1_TextChanged(object sender, EventArgs e)
        {

        Checking_text_for_a_number(DurTextBoxCh1.Text, out bool res);
            if (res == true)
            {
            }
            else 
            {
                DurTextBoxCh1.Clear();
            }

            if (DurTextBoxCh1.Text == "")
            {
                DurTextBoxCh1.Text = "0";
            }
             
            string buf = DurTextBoxCh1.Text;
            DurationPulseCH1 = Convert.ToInt16(buf);
            DurationMassiveDataCH1 = BitConverter.GetBytes(DurationPulseCH1);
        }

        public void DelTextBoxch1_TextChanged(object sender, EventArgs e)                       
        {
        Checking_text_for_a_number(DelTextBoxch1.Text, out bool res);                           
            if (res == true)
            {
            }
            else                                                                                
            {
                DelTextBoxch1.Clear();                                                          
            }

            if (DelTextBoxch1.Text == "")
            {
                DelTextBoxch1.Text = "0";
            }

            string buf = DelTextBoxch1.Text;
            DelBetweenPulseCH1 = Convert.ToInt16(buf);
            DelayMassiveDataCH1 = BitConverter.GetBytes(DelBetweenPulseCH1);
        }
 
        public void DurComboBoxCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (DurComboBoxCh1.Text == "*10 нс")
            {
                DurMultiplierCH1 = 1;
            }
            if (DurComboBoxCh1.Text == "мкс")
            {
                DurMultiplierCH1 = 2;
            }
            if (DurComboBoxCh1.Text == "мс")
            {
                DurMultiplierCH1 = 3;
            }
            if (DurComboBoxCh1.Text == "c")
            {
                DurMultiplierCH1 = 4;
            }
        }

        public void DelComboBoxCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh1.Text == "*10 нс")
            {
                DelMultiplierCH1 = 1;
            }
            if (DelComboBoxCh1.Text == "мкс")
            {
                DelMultiplierCH1 = 2;
            }
            if (DelComboBoxCh1.Text == "мс")
            {
                DelMultiplierCH1 = 3;
            }
            if (DelComboBoxCh1.Text == "c")
            {
                DelMultiplierCH1 = 4;
            }
        }

        public void ComboBoxTypeStartCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh1.Text == "Общий")
            {
                TypeStartCH1 = 1;
            }
            if (ComboBoxTypeStartCh1.Text == "От предыдущего")
            {
                TypeStartCH1 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №2      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh2_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh2.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh2.Clear();
            }

            if (DurTextBoxCh2.Text == "")
            {
                DurTextBoxCh2.Text = "0";
            }

            string buf = DurTextBoxCh2.Text;
            DurationPulseCH2 = Convert.ToInt16(buf);
            DurationMassiveDataCH2 = BitConverter.GetBytes(DurationPulseCH2);
        }

        public void DelTextBoxch2_TextChanged(object sender, EventArgs e)  
        {
            Checking_text_for_a_number(DelTextBoxch2.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch2.Clear();
            }

            if (DelTextBoxch2.Text == "")
            {
                DelTextBoxch2.Text = "0";
            }

            string buf = DelTextBoxch2.Text;
            DelBetweenPulseCH2 = Convert.ToInt16(buf);
            DelayMassiveDataCH2 = BitConverter.GetBytes(DelBetweenPulseCH2);
        }

        public void DurComboBoxCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh2.Text == "*10 нс")
            {
                DurMultiplierCH2 = 1;
            }
            if (DurComboBoxCh2.Text == "мкс")
            {
                DurMultiplierCH2 = 2;
            }
            if (DurComboBoxCh2.Text == "мс")
            {
                DurMultiplierCH2 = 3;
            }
            if (DurComboBoxCh2.Text == "c")
            {
                DurMultiplierCH2 = 4;
            }
        }

        public void DelComboBoxCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh2.Text == "*10 нс")
            {
                DelMultiplierCH2 = 1;
            }
            if (DelComboBoxCh2.Text == "мкс")
            {
                DelMultiplierCH2 = 2;
            }
            if (DelComboBoxCh2.Text == "мс")
            {
                DelMultiplierCH2 = 3;
            }
            if (DelComboBoxCh2.Text == "c")
            {
                DelMultiplierCH2 = 4;
            }
        }

        public void ComboBoxTypeStartCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh2.Text == "Общий")
            {
                TypeStartCH2 = 1;
            }
            if (ComboBoxTypeStartCh2.Text == "От предыдущего")
            {
                TypeStartCH2 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №3      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh3_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh3.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh3.Clear();
            }

            if (DurTextBoxCh3.Text == "")
            {
                DurTextBoxCh3.Text = "0";
            }

            string buf = DurTextBoxCh3.Text;
            DurationPulseCH3 = Convert.ToInt16(buf);
            DurationMassiveDataCH3 = BitConverter.GetBytes(DurationPulseCH3);
        }

        public void DelTextBoxch3_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch3.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch3.Clear();
            }

            if (DelTextBoxch3.Text == "")
            {
                DelTextBoxch3.Text = "0";
            }

            string buf = DelTextBoxch3.Text;
            DelBetweenPulseCH3 = Convert.ToInt16(buf);
            DelayMassiveDataCH3 = BitConverter.GetBytes(DelBetweenPulseCH3);
        }

        public void DurComboBoxCh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh3.Text == "*10 нс")
            {
                DurMultiplierCH3 = 1;
            }
            if (DurComboBoxCh3.Text == "мкс")
            {
                DurMultiplierCH3 = 2;
            }
            if (DurComboBoxCh3.Text == "мс")
            {
                DurMultiplierCH3 = 3;
            }
            if (DurComboBoxCh3.Text == "c")
            {
                DurMultiplierCH3 = 4;
            }
        }

        public void DelComboBoxCh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh3.Text == "*10 нс")
            {
                DelMultiplierCH3 = 1;
            }
            if (DelComboBoxCh3.Text == "мкс")
            {
                DelMultiplierCH3 = 2;
            }
            if (DelComboBoxCh3.Text == "мс")
            {
                DelMultiplierCH3 = 3;
            }
            if (DelComboBoxCh3.Text == "c")
            {
                DelMultiplierCH3 = 4;
            }
        }

        public void ComboBoxTypeStartCh3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh3.Text == "Общий")
            {
                TypeStartCH3 = 1;
            }
            if (ComboBoxTypeStartCh3.Text == "От предыдущего")
            {
                TypeStartCH3 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №4      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh4_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh4.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh4.Clear();
            }

            if (DurTextBoxCh4.Text == "")
            {
                DurTextBoxCh4.Text = "0";
            }

            string buf = DurTextBoxCh4.Text;
            DurationPulseCH4 = Convert.ToInt16(buf);
            DurationMassiveDataCH4 = BitConverter.GetBytes(DurationPulseCH4);
        }

        public void DelTextBoxch4_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch4.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch4.Clear();
            }

            if (DelTextBoxch4.Text == "")
            {
                DelTextBoxch4.Text = "0";
            }

            string buf = DelTextBoxch4.Text;
            DelBetweenPulseCH4 = Convert.ToInt16(buf);
            DelayMassiveDataCH4 = BitConverter.GetBytes(DelBetweenPulseCH4);
        }

        public void DurComboBoxCh4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh4.Text == "*10 нс")
            {
                DurMultiplierCH4 = 1;
            }
            if (DurComboBoxCh4.Text == "мкс")
            {
                DurMultiplierCH4 = 2;
            }
            if (DurComboBoxCh4.Text == "мс")
            {
                DurMultiplierCH4 = 3;
            }
            if (DurComboBoxCh4.Text == "c")
            {
                DurMultiplierCH4 = 4;
            }
        }

        public void DelComboBoxCh4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh4.Text == "*10 нс")
            {
                DelMultiplierCH4 = 1;
            }
            if (DelComboBoxCh4.Text == "мкс")
            {
                DelMultiplierCH4 = 2;
            }
            if (DelComboBoxCh4.Text == "мс")
            {
                DelMultiplierCH4 = 3;
            }
            if (DelComboBoxCh4.Text == "c")
            {
                DelMultiplierCH4 = 4;
            }
        }

        public void ComboBoxTypeStartCh4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh4.Text == "Общий")
            {
                TypeStartCH4 = 1;
            }
            if (ComboBoxTypeStartCh4.Text == "От предыдущего")
            {
                TypeStartCH4 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №5      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh5_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh5.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh5.Clear();
            }

            if (DurTextBoxCh5.Text == "")
            {
                DurTextBoxCh5.Text = "0";
            }

            string buf = DurTextBoxCh5.Text;
            DurationPulseCH5 = Convert.ToInt16(buf);
            DurationMassiveDataCH5 = BitConverter.GetBytes(DurationPulseCH5);
        }

        public void DelTextBoxch5_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch5.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch5.Clear();
            }

            if (DelTextBoxch5.Text == "")
            {
                DelTextBoxch5.Text = "0";
            }

            string buf = DelTextBoxch5.Text;
            DelBetweenPulseCH5 = Convert.ToInt16(buf);
            DelayMassiveDataCH5 = BitConverter.GetBytes(DelBetweenPulseCH5);
        }

        public void DurComboBoxCh5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh5.Text == "*10 нс")
            {
                DurMultiplierCH5 = 1;
            }
            if (DurComboBoxCh5.Text == "мкс")
            {
                DurMultiplierCH5 = 2;
            }
            if (DurComboBoxCh5.Text == "мс")
            {
                DurMultiplierCH5 = 3;
            }
            if (DurComboBoxCh5.Text == "c")
            {
                DurMultiplierCH5 = 4;
            }
        }

        public void DelComboBoxCh5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh5.Text == "*10 нс")
            {
                DelMultiplierCH5 = 1;
            }
            if (DelComboBoxCh5.Text == "мкс")
            {
                DelMultiplierCH5 = 2;
            }
            if (DelComboBoxCh5.Text == "мс")
            {
                DelMultiplierCH5 = 3;
            }
            if (DelComboBoxCh5.Text == "c")
            {
                DelMultiplierCH5 = 4;
            }
        }

        public void ComboBoxTypeStartCh5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh5.Text == "Общий")
            {
                TypeStartCH5 = 1;
            }
            if (ComboBoxTypeStartCh5.Text == "От предыдущего")
            {
                TypeStartCH5 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №6      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh6_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh6.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh6.Clear();
            }

            if (DurTextBoxCh6.Text == "")
            {
                DurTextBoxCh6.Text = "0";
            }

            string buf = DurTextBoxCh6.Text;
            DurationPulseCH6 = Convert.ToInt16(buf);
            DurationMassiveDataCH6 = BitConverter.GetBytes(DurationPulseCH6);
        }

        public void DelTextBoxch6_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch6.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch6.Clear();
            }

            if (DelTextBoxch6.Text == "")
            {
                DelTextBoxch6.Text = "0";
            }

            string buf = DelTextBoxch6.Text;
            DelBetweenPulseCH6 = Convert.ToInt16(buf);
            DelayMassiveDataCH6 = BitConverter.GetBytes(DelBetweenPulseCH6);
        }

        public void DurComboBoxCh6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh6.Text == "*10 нс")
            {
                DurMultiplierCH6 = 1;
            }
            if (DurComboBoxCh6.Text == "мкс")
            {
                DurMultiplierCH6 = 2;
            }
            if (DurComboBoxCh6.Text == "мс")
            {
                DurMultiplierCH6 = 3;
            }
            if (DurComboBoxCh6.Text == "c")
            {
                DurMultiplierCH6 = 4;
            }
        }

        public void DelComboBoxCh6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh6.Text == "*10 нс")
            {
                DelMultiplierCH6 = 1;
            }
            if (DelComboBoxCh6.Text == "мкс")
            {
                DelMultiplierCH6 = 2;
            }
            if (DelComboBoxCh6.Text == "мс")
            {
                DelMultiplierCH6 = 3;
            }
            if (DelComboBoxCh6.Text == "c")
            {
                DelMultiplierCH6 = 4;
            }
        }

        public void ComboBoxTypeStartCh6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh6.Text == "Общий")
            {
                TypeStartCH6 = 1;
            }
            if (ComboBoxTypeStartCh6.Text == "От предыдущего")
            {
                TypeStartCH6 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №7      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh7_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh7.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh7.Clear();
            }

            if (DurTextBoxCh7.Text == "")
            {
                DurTextBoxCh7.Text = "0";
            }

            string buf = DurTextBoxCh7.Text;
            DurationPulseCH7 = Convert.ToInt16(buf);
            DurationMassiveDataCH7 = BitConverter.GetBytes(DurationPulseCH7);
        }

        public void DelTextBoxch7_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch7.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch7.Clear();
            }

            if (DelTextBoxch7.Text == "")
            {
                DelTextBoxch7.Text = "0";
            }

            string buf = DelTextBoxch7.Text;
            DelBetweenPulseCH7 = Convert.ToInt16(buf);
            DelayMassiveDataCH7 = BitConverter.GetBytes(DelBetweenPulseCH7);
        }

        public void DurComboBoxCh7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh7.Text == "*10 нс")
            {
                DurMultiplierCH7 = 1;
            }
            if (DurComboBoxCh7.Text == "мкс")
            {
                DurMultiplierCH7 = 2;
            }
            if (DurComboBoxCh7.Text == "мс")
            {
                DurMultiplierCH7 = 3;
            }
            if (DurComboBoxCh7.Text == "c")
            {
                DurMultiplierCH7 = 4;
            }
        }

        public void DelComboBoxCh7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh7.Text == "*10 нс")
            {
                DelMultiplierCH7 = 1;
            }
            if (DelComboBoxCh7.Text == "мкс")
            {
                DelMultiplierCH7 = 2;
            }
            if (DelComboBoxCh7.Text == "мс")
            {
                DelMultiplierCH7 = 3;
            }
            if (DelComboBoxCh7.Text == "c")
            {
                DelMultiplierCH7 = 4;
            }
        }

        public void ComboBoxTypeStartCh7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh7.Text == "Общий")
            {
                TypeStartCH7 = 1;
            }
            if (ComboBoxTypeStartCh7.Text == "От предыдущего")
            {
                TypeStartCH7 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №8      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh8_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh8.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh8.Clear();
            }

            if (DurTextBoxCh8.Text == "")
            {
                DurTextBoxCh8.Text = "0";
            }

            string buf = DurTextBoxCh8.Text;
            DurationPulseCH8 = Convert.ToInt16(buf);
            DurationMassiveDataCH8 = BitConverter.GetBytes(DurationPulseCH8);
        }

        public void DelTextBoxch8_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch8.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch8.Clear();
            }

            if (DelTextBoxch8.Text == "")
            {
                DelTextBoxch8.Text = "0";
            }

            string buf = DelTextBoxch8.Text;
            DelBetweenPulseCH8 = Convert.ToInt16(buf);
            DelayMassiveDataCH8 = BitConverter.GetBytes(DelBetweenPulseCH8);
        }

        public void DurComboBoxCh8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh8.Text == "*10 нс")
            {
                DurMultiplierCH8 = 1;
            }
            if (DurComboBoxCh8.Text == "мкс")
            {
                DurMultiplierCH8 = 2;
            }
            if (DurComboBoxCh8.Text == "мс")
            {
                DurMultiplierCH8 = 3;
            }
            if (DurComboBoxCh8.Text == "c")
            {
                DurMultiplierCH8 = 4;
            }
        }

        public void DelComboBoxCh8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh8.Text == "*10 нс")
            {
                DelMultiplierCH8 = 1;
            }
            if (DelComboBoxCh8.Text == "мкс")
            {
                DelMultiplierCH8 = 2;
            }
            if (DelComboBoxCh8.Text == "мс")
            {
                DelMultiplierCH8 = 3;
            }
            if (DelComboBoxCh8.Text == "c")
            {
                DelMultiplierCH8 = 4;
            }
        }

        public void ComboBoxTypeStartCh8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh8.Text == "Общий")
            {
                TypeStartCH8 = 1;
            }
            if (ComboBoxTypeStartCh8.Text == "От предыдущего")
            {
                TypeStartCH8 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №9      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh9_TextChanged(object sender, EventArgs e)
        {


            Checking_text_for_a_number(DurTextBoxCh9.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh9.Clear();
            }

            if (DurTextBoxCh9.Text == "")
            {
                DurTextBoxCh9.Text = "0";
            }

            string buf = DurTextBoxCh9.Text;
            DurationPulseCH9 = Convert.ToInt16(buf);
            DurationMassiveDataCH9 = BitConverter.GetBytes(DurationPulseCH9);
        }

        public void DelTextBoxch9_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch9.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch9.Clear();
            }

            if (DelTextBoxch9.Text == "")
            {
                DelTextBoxch9.Text = "0";
            }

            string buf = DelTextBoxch9.Text;
            DelBetweenPulseCH9 = Convert.ToInt16(buf);
            DelayMassiveDataCH9 = BitConverter.GetBytes(DelBetweenPulseCH9);
        }

        public void DurComboBoxCh9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh9.Text == "*10 нс")
            {
                DurMultiplierCH9 = 1;
            }
            if (DurComboBoxCh9.Text == "мкс")
            {
                DurMultiplierCH9 = 2;
            }
            if (DurComboBoxCh9.Text == "мс")
            {
                DurMultiplierCH9 = 3;
            }
            if (DurComboBoxCh9.Text == "c")
            {
                DurMultiplierCH9 = 4;
            }
        }

        public void DelComboBoxCh9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh9.Text == "*10 нс")
            {
                DelMultiplierCH9 = 1;
            }
            if (DelComboBoxCh9.Text == "мкс")
            {
                DelMultiplierCH9 = 2;
            }
            if (DelComboBoxCh9.Text == "мс")
            {
                DelMultiplierCH9 = 3;
            }
            if (DelComboBoxCh9.Text == "c")
            {
                DelMultiplierCH9 = 4;
            }
        }

        public void ComboBoxTypeStartCh9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh9.Text == "Общий")
            {
                TypeStartCH9 = 1;
            }
            if (ComboBoxTypeStartCh9.Text == "От предыдущего")
            {
                TypeStartCH9 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №10      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh10_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh10.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh10.Clear();
            }

            if (DurTextBoxCh10.Text == "")
            {
                DurTextBoxCh10.Text = "0";
            }

            string buf = DurTextBoxCh10.Text;
            DurationPulseCH10 = Convert.ToInt16(buf);
            DurationMassiveDataCH10 = BitConverter.GetBytes(DurationPulseCH10);
        }

        public void DelTextBoxch10_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch10.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch10.Clear();
            }

            if (DelTextBoxch10.Text == "")
            {
                DelTextBoxch10.Text = "0";
            }

            string buf = DelTextBoxch10.Text;
            DelBetweenPulseCH10 = Convert.ToInt16(buf);
            DelayMassiveDataCH10 = BitConverter.GetBytes(DelBetweenPulseCH10);
        }

        public void DurComboBoxCh10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh10.Text == "*10 нс")
            {
                DurMultiplierCH10 = 1;
            }
            if (DurComboBoxCh10.Text == "мкс")
            {
                DurMultiplierCH10 = 2;
            }
            if (DurComboBoxCh10.Text == "мс")
            {
                DurMultiplierCH10 = 3;
            }
            if (DurComboBoxCh10.Text == "c")
            {
                DurMultiplierCH10 = 4;
            }
        }

        public void DelComboBoxCh10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh10.Text == "*10 нс")
            {
                DelMultiplierCH10 = 1;
            }
            if (DelComboBoxCh10.Text == "мкс")
            {
                DelMultiplierCH10 = 2;
            }
            if (DelComboBoxCh10.Text == "мс")
            {
                DelMultiplierCH10 = 3;
            }
            if (DelComboBoxCh10.Text == "c")
            {
                DelMultiplierCH10 = 4;
            }
        }

        public void ComboBoxTypeStartCh10_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh10.Text == "Общий")
            {
                TypeStartCH10 = 1;
            }
            if (ComboBoxTypeStartCh10.Text == "От предыдущего")
            {
                TypeStartCH10 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №11      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh11_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh11.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh11.Clear();
            }

            if (DurTextBoxCh11.Text == "")
            {
                DurTextBoxCh11.Text = "0";
            }

            string buf = DurTextBoxCh11.Text;
            DurationPulseCH11 = Convert.ToInt16(buf);
            DurationMassiveDataCH11 = BitConverter.GetBytes(DurationPulseCH11);
        }

        public void DelTextBoxch11_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch11.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch11.Clear();
            }

            if (DelTextBoxch11.Text == "")
            {
                DelTextBoxch11.Text = "0";
            }

            string buf = DelTextBoxch11.Text;
            DelBetweenPulseCH11 = Convert.ToInt16(buf);
            DelayMassiveDataCH11 = BitConverter.GetBytes(DelBetweenPulseCH11);
        }

        public void DurComboBoxCh11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh11.Text == "*10 нс")
            {
                DurMultiplierCH11 = 1;
            }
            if (DurComboBoxCh11.Text == "мкс")
            {
                DurMultiplierCH11 = 2;
            }
            if (DurComboBoxCh11.Text == "мс")
            {
                DurMultiplierCH11 = 3;
            }
            if (DurComboBoxCh11.Text == "c")
            {
                DurMultiplierCH11 = 4;
            }
        }

        public void DelComboBoxCh11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh11.Text == "*10 нс")
            {
                DelMultiplierCH11 = 1;
            }
            if (DelComboBoxCh11.Text == "мкс")
            {
                DelMultiplierCH11 = 2;
            }
            if (DelComboBoxCh11.Text == "мс")
            {
                DelMultiplierCH11 = 3;
            }
            if (DelComboBoxCh11.Text == "c")
            {
                DelMultiplierCH11 = 4;
            }
        }

        public void ComboBoxTypeStartCh11_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh11.Text == "Общий")
            {
                TypeStartCH11 = 1;
            }
            if (ComboBoxTypeStartCh11.Text == "От предыдущего")
            {
                TypeStartCH11 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №12      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh12_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh12.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh12.Clear();
            }

            if (DurTextBoxCh12.Text == "")
            {
                DurTextBoxCh12.Text = "0";
            }

            string buf = DurTextBoxCh12.Text;
            DurationPulseCH12 = Convert.ToInt16(buf);
            DurationMassiveDataCH12 = BitConverter.GetBytes(DurationPulseCH12);
        }

        public void DelTextBoxch12_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch12.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch12.Clear();
            }

            if (DelTextBoxch12.Text == "")
            {
                DelTextBoxch12.Text = "0";
            }

            string buf = DelTextBoxch12.Text;
            DelBetweenPulseCH12 = Convert.ToInt16(buf);
            DelayMassiveDataCH12 = BitConverter.GetBytes(DelBetweenPulseCH12);
        }

        public void DurComboBoxCh12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh12.Text == "*10 нс")
            {
                DurMultiplierCH12 = 1;
            }
            if (DurComboBoxCh12.Text == "мкс")
            {
                DurMultiplierCH12 = 2;
            }
            if (DurComboBoxCh12.Text == "мс")
            {
                DurMultiplierCH12 = 3;
            }
            if (DurComboBoxCh12.Text == "c")
            {
                DurMultiplierCH12 = 4;
            }
        }

        public void DelComboBoxCh12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh12.Text == "*10 нс")
            {
                DelMultiplierCH12 = 1;
            }
            if (DelComboBoxCh12.Text == "мкс")
            {
                DelMultiplierCH12 = 2;
            }
            if (DelComboBoxCh12.Text == "мс")
            {
                DelMultiplierCH12 = 3;
            }
            if (DelComboBoxCh12.Text == "c")
            {
                DelMultiplierCH12 = 4;
            }
        }

        public void ComboBoxTypeStartCh12_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh12.Text == "Общий")
            {
                TypeStartCH12 = 1;
            }
            if (ComboBoxTypeStartCh12.Text == "От предыдущего")
            {
                TypeStartCH12 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №13      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh13_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh13.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh13.Clear();
            }

            if (DurTextBoxCh13.Text == "")
            {
                DurTextBoxCh13.Text = "0";
            }

            string buf = DurTextBoxCh13.Text;
            DurationPulseCH13 = Convert.ToInt16(buf);
            DurationMassiveDataCH13 = BitConverter.GetBytes(DurationPulseCH13);
        }

        public void DelTextBoxch13_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch13.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch13.Clear();
            }

            if (DelTextBoxch13.Text == "")
            {
                DelTextBoxch13.Text = "0";
            }

            string buf = DelTextBoxch13.Text;
            DelBetweenPulseCH13 = Convert.ToInt16(buf);
            DelayMassiveDataCH13 = BitConverter.GetBytes(DelBetweenPulseCH13);
        }

        public void DurComboBoxCh13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh13.Text == "*10 нс")
            {
                DurMultiplierCH13 = 1;
            }
            if (DurComboBoxCh13.Text == "мкс")
            {
                DurMultiplierCH13 = 2;
            }
            if (DurComboBoxCh13.Text == "мс")
            {
                DurMultiplierCH13 = 3;
            }
            if (DurComboBoxCh13.Text == "c")
            {
                DurMultiplierCH13 = 4;
            }
        }

        public void DelComboBoxCh13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh13.Text == "*10 нс")
            {
                DelMultiplierCH13 = 1;
            }
            if (DelComboBoxCh13.Text == "мкс")
            {
                DelMultiplierCH13 = 2;
            }
            if (DelComboBoxCh13.Text == "мс")
            {
                DelMultiplierCH13 = 3;
            }
            if (DelComboBoxCh13.Text == "c")
            {
                DelMultiplierCH13 = 4;
            }
        }

        public void ComboBoxTypeStartCh13_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh13.Text == "Общий")
            {
                TypeStartCH13 = 1;
            }
            if (ComboBoxTypeStartCh13.Text == "От предыдущего")
            {
                TypeStartCH13 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////        
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №14      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh14_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh14.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh14.Clear();
            }

            if (DurTextBoxCh14.Text == "")
            {
                DurTextBoxCh14.Text = "0";
            }

            string buf = DurTextBoxCh14.Text;
            DurationPulseCH14 = Convert.ToInt16(buf);
            DurationMassiveDataCH14 = BitConverter.GetBytes(DurationPulseCH14);
        }

        public void DelTextBoxch14_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch14.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch14.Clear();
            }

            if (DelTextBoxch14.Text == "")
            {
                DelTextBoxch14.Text = "0";
            }

            string buf = DelTextBoxch14.Text;
            DelBetweenPulseCH14 = Convert.ToInt16(buf);
            DelayMassiveDataCH14 = BitConverter.GetBytes(DelBetweenPulseCH14);
        }

        public void DurComboBoxCh14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh14.Text == "*10 нс")
            {
                DurMultiplierCH14 = 1;
            }
            if (DurComboBoxCh14.Text == "мкс")
            {
                DurMultiplierCH14 = 2;
            }
            if (DurComboBoxCh14.Text == "мс")
            {
                DurMultiplierCH14 = 3;
            }
            if (DurComboBoxCh14.Text == "c")
            {
                DurMultiplierCH14 = 4;
            }
        }

        public void DelComboBoxCh14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh14.Text == "*10 нс")
            {
                DelMultiplierCH14 = 1;
            }
            if (DelComboBoxCh14.Text == "мкс")
            {
                DelMultiplierCH14 = 2;
            }
            if (DelComboBoxCh14.Text == "мс")
            {
                DelMultiplierCH14 = 3;
            }
            if (DelComboBoxCh14.Text == "c")
            {
                DelMultiplierCH14 = 4;
            }
        }

        public void ComboBoxTypeStartCh14_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh14.Text == "Общий")
            {
                TypeStartCH14 = 1;
            }
            if (ComboBoxTypeStartCh14.Text == "От предыдущего")
            {
                TypeStartCH14 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////     
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №15      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh15_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh15.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh15.Clear();
            }

            if (DurTextBoxCh15.Text == "")
            {
                DurTextBoxCh15.Text = "0";
            }

            string buf = DurTextBoxCh15.Text;
            DurationPulseCH15 = Convert.ToInt16(buf);
            DurationMassiveDataCH15 = BitConverter.GetBytes(DurationPulseCH15);
        }

        public void DelTextBoxch15_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch15.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch15.Clear();
            }

            if (DelTextBoxch15.Text == "")
            {
                DelTextBoxch15.Text = "0";
            }

            string buf = DelTextBoxch15.Text;
            DelBetweenPulseCH15 = Convert.ToInt16(buf);
            DelayMassiveDataCH15 = BitConverter.GetBytes(DelBetweenPulseCH15);
        }

        public void DurComboBoxCh15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh15.Text == "*10 нс")
            {
                DurMultiplierCH15 = 1;
            }
            if (DurComboBoxCh15.Text == "мкс")
            {
                DurMultiplierCH15 = 2;
            }
            if (DurComboBoxCh15.Text == "мс")
            {
                DurMultiplierCH15 = 3;
            }
            if (DurComboBoxCh15.Text == "c")
            {
                DurMultiplierCH15 = 4;
            }
        }

        public void DelComboBoxCh15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh15.Text == "*10 нс")
            {
                DelMultiplierCH15 = 1;
            }
            if (DelComboBoxCh15.Text == "мкс")
            {
                DelMultiplierCH15 = 2;
            }
            if (DelComboBoxCh15.Text == "мс")
            {
                DelMultiplierCH15 = 3;
            }
            if (DelComboBoxCh15.Text == "c")
            {
                DelMultiplierCH15 = 4;
            }
        }

        public void ComboBoxTypeStartCh15_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh15.Text == "Общий")
            {
                TypeStartCH15 = 1;
            }
            if (ComboBoxTypeStartCh15.Text == "От предыдущего")
            {
                TypeStartCH15 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        ///////////////////////////////////////////////////////////////////////////////////////////////////////     КАНАЛ №16      //////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public void DurTextBoxCh16_TextChanged(object sender, EventArgs e)
        {

            Checking_text_for_a_number(DurTextBoxCh16.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DurTextBoxCh16.Clear();
            }

            if (DurTextBoxCh16.Text == "")
            {
                DurTextBoxCh16.Text = "0";
            }

            string buf = DurTextBoxCh16.Text;
            DurationPulseCH16 = Convert.ToInt16(buf);
            DurationMassiveDataCH16 = BitConverter.GetBytes(DurationPulseCH16);
        }

        public void DelTextBoxch16_TextChanged(object sender, EventArgs e)
        {
            Checking_text_for_a_number(DelTextBoxch16.Text, out bool res);
            if (res == true)
            {
            }
            else
            {
                DelTextBoxch16.Clear();
            }

            if (DelTextBoxch16.Text == "")
            {
                DelTextBoxch16.Text = "0";
            }

            string buf = DelTextBoxch16.Text;
            DelBetweenPulseCH16 = Convert.ToInt16(buf);
            DelayMassiveDataCH16 = BitConverter.GetBytes(DelBetweenPulseCH16);
        }

        public void DurComboBoxCh16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh16.Text == "*10 нс")
            {
                DurMultiplierCH16 = 1;
            }
            if (DurComboBoxCh16.Text == "мкс")
            {
                DurMultiplierCH16 = 2;
            }
            if (DurComboBoxCh16.Text == "мс")
            {
                DurMultiplierCH16 = 3;
            }
            if (DurComboBoxCh16.Text == "c")
            {
                DurMultiplierCH16 = 4;
            }
        }

        public void DelComboBoxCh16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh16.Text == "*10 нс")
            {
                DelMultiplierCH16 = 1;
            }
            if (DelComboBoxCh16.Text == "мкс")
            {
                DelMultiplierCH16 = 2;
            }
            if (DelComboBoxCh16.Text == "мс")
            {
                DelMultiplierCH16 = 3;
            }
            if (DelComboBoxCh16.Text == "c")
            {
                DelMultiplierCH16 = 4;
            }
        }

        public void ComboBoxTypeStartCh16_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh16.Text == "Общий")
            {
                TypeStartCH16 = 1;
            }
            if (ComboBoxTypeStartCh16.Text == "От предыдущего")
            {
                TypeStartCH16 = 2;
            }
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////       
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        public bool Checking_text_for_a_number(string text, out bool res)                        // Функция проверки текста на число               
        {
            bool IsDigit = text.Length == text.Where(c => char.IsDigit(c)).Count();

            if (IsDigit == true)
            {
            }
            else
            {
                MessageBox.Show("Введите число от 1 до 999", "Сообщение",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
                //MessageBoxOptions.ServiceNotification);
            }
            return res = IsDigit;
        }

       public void ButtonOneInAll_Click(object sender, EventArgs e)                           // По нажатию данной кнопки происходит запись конфигурации 1-го канала во все другие каналы
        {
            DurTextBoxCh2.Text = DurTextBoxCh3.Text = DurTextBoxCh4.Text = DurTextBoxCh5.Text = DurTextBoxCh6.Text = DurTextBoxCh7.Text = DurTextBoxCh8.Text = DurTextBoxCh9.Text =
            DurTextBoxCh10.Text = DurTextBoxCh11.Text = DurTextBoxCh12.Text = DurTextBoxCh13.Text = DurTextBoxCh14.Text = DurTextBoxCh15.Text = DurTextBoxCh16.Text = DurTextBoxCh1.Text;

            DelTextBoxch2.Text = DelTextBoxch3.Text = DelTextBoxch4.Text = DelTextBoxch5.Text = DelTextBoxch6.Text = DelTextBoxch7.Text = DelTextBoxch8.Text = DelTextBoxch9.Text =
            DelTextBoxch10.Text = DelTextBoxch11.Text = DelTextBoxch12.Text = DelTextBoxch13.Text = DelTextBoxch14.Text = DelTextBoxch15.Text = DelTextBoxch16.Text = DelTextBoxch1.Text; 

            ComboBoxTypeStartCh2.Text = ComboBoxTypeStartCh3.Text = ComboBoxTypeStartCh4.Text = ComboBoxTypeStartCh5.Text = ComboBoxTypeStartCh6.Text = ComboBoxTypeStartCh7.Text =
            ComboBoxTypeStartCh8.Text = ComboBoxTypeStartCh9.Text = ComboBoxTypeStartCh10.Text = ComboBoxTypeStartCh11.Text = ComboBoxTypeStartCh12.Text = ComboBoxTypeStartCh13.Text =
            ComboBoxTypeStartCh14.Text = ComboBoxTypeStartCh15.Text = ComboBoxTypeStartCh16.Text = ComboBoxTypeStartCh1.Text;

            DelComboBoxCh2.Text = DelComboBoxCh3.Text = DelComboBoxCh4.Text = DelComboBoxCh5.Text = DelComboBoxCh6.Text = DelComboBoxCh7.Text = DelComboBoxCh8.Text = DelComboBoxCh9.Text =
            DelComboBoxCh10.Text = DelComboBoxCh11.Text = DelComboBoxCh12.Text = DelComboBoxCh13.Text = DelComboBoxCh14.Text = DelComboBoxCh15.Text = DelComboBoxCh16.Text = DelComboBoxCh1.Text;

            DurComboBoxCh2.Text = DurComboBoxCh3.Text = DurComboBoxCh4.Text = DurComboBoxCh5.Text = DurComboBoxCh6.Text = DurComboBoxCh7.Text = DurComboBoxCh8.Text = DurComboBoxCh9.Text =
            DurComboBoxCh10.Text = DurComboBoxCh11.Text = DurComboBoxCh12.Text = DurComboBoxCh13.Text = DurComboBoxCh14.Text = DurComboBoxCh15.Text = DurComboBoxCh16.Text = DurComboBoxCh1.Text;
        }

        public void CearAllCh_Click(object sender, EventArgs e)                                // По нажатию данной кнопки происходит очистка конфигурации всех каналов
        {
            DurTextBoxCh2.Text = DurTextBoxCh3.Text = DurTextBoxCh4.Text = DurTextBoxCh5.Text = DurTextBoxCh6.Text = DurTextBoxCh7.Text = DurTextBoxCh8.Text = DurTextBoxCh9.Text =
            DurTextBoxCh10.Text = DurTextBoxCh11.Text = DurTextBoxCh12.Text = DurTextBoxCh13.Text = DurTextBoxCh14.Text = DurTextBoxCh15.Text = DurTextBoxCh16.Text = DurTextBoxCh1.Text =

            DelTextBoxch2.Text = DelTextBoxch3.Text = DelTextBoxch4.Text = DelTextBoxch5.Text = DelTextBoxch6.Text = DelTextBoxch7.Text = DelTextBoxch8.Text = DelTextBoxch9.Text =
            DelTextBoxch10.Text = DelTextBoxch11.Text = DelTextBoxch12.Text = DelTextBoxch13.Text = DelTextBoxch14.Text = DelTextBoxch15.Text = DelTextBoxch16.Text = DelTextBoxch1.Text = "0";

            ComboBoxTypeStartCh2.Text = ComboBoxTypeStartCh3.Text = ComboBoxTypeStartCh4.Text = ComboBoxTypeStartCh5.Text = ComboBoxTypeStartCh6.Text = ComboBoxTypeStartCh7.Text =
            ComboBoxTypeStartCh8.Text = ComboBoxTypeStartCh9.Text = ComboBoxTypeStartCh10.Text = ComboBoxTypeStartCh11.Text = ComboBoxTypeStartCh12.Text = ComboBoxTypeStartCh13.Text =
            ComboBoxTypeStartCh14.Text = ComboBoxTypeStartCh15.Text = ComboBoxTypeStartCh16.Text = ComboBoxTypeStartCh1.Text =

            DelComboBoxCh2.Text = DelComboBoxCh3.Text = DelComboBoxCh4.Text = DelComboBoxCh5.Text = DelComboBoxCh6.Text = DelComboBoxCh7.Text = DelComboBoxCh8.Text = DelComboBoxCh9.Text =
            DelComboBoxCh10.Text = DelComboBoxCh11.Text = DelComboBoxCh12.Text = DelComboBoxCh13.Text = DelComboBoxCh14.Text = DelComboBoxCh15.Text = DelComboBoxCh16.Text = DelComboBoxCh1.Text =

            DurComboBoxCh2.Text = DurComboBoxCh3.Text = DurComboBoxCh4.Text = DurComboBoxCh5.Text = DurComboBoxCh6.Text = DurComboBoxCh7.Text = DurComboBoxCh8.Text = DurComboBoxCh9.Text =
            DurComboBoxCh10.Text = DurComboBoxCh11.Text = DurComboBoxCh12.Text = DurComboBoxCh13.Text = DurComboBoxCh14.Text = DurComboBoxCh15.Text = DurComboBoxCh16.Text = DurComboBoxCh1.Text = "";

            int count = 112;
            int offset = 0;
            byte[] CLBUF = new byte[] {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                       0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                       0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                       0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,};

            if (Port.IsOpen == false)                                                           // Если порт закрыт (а закрыт он может быть только потому что мы его не выбрали в СОМ комбобоксе)
            {
                MessageBox.Show("Выберите СОМ порт", "Сообщение",                               // Выводим сообщение призывающее выбрать СОМ порт
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                // MessageBoxOptions.ServiceNotification);
            }
            else
            {
                Port.Write(CLBUF, offset, count);
             //   CearAllCh.Click -= new System.EventHandler(this.CearAllCh_Click);
             //   CearAllCh.Enabled = false;
            //    Thread.Sleep(500);
             //   CearAllCh.Enabled = true;
             //   CearAllCh.Click += new System.EventHandler(CearAllCh_Click);



            }


            // Thread.Sleep(1000);

        }




    }


}





