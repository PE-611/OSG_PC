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


        }



        SerialPort Port = new SerialPort("COM", 9600, Parity.None, 8, StopBits.Two);            // Инициализация последовательного порта 
        // _serialPort.Handshake = Handshake.None;

        public void ComComboBox_SelectedIndexChanged(object sender, EventArgs e)                // При выборе СОМ порта осуществляем:
        {
            if (Port.IsOpen == false)
            {
                Port.PortName = ComComboBox.Text.ToString();                                    // Изменение имени Комбобокса
                Port.Open();                                                                    // Открываем порт
                Port.BaudRate = 9600;
                //Port.WriteTimeout = 500;                                                      // Эти тайм ауты можно не ставить
                //Port.ReadTimeout = 500;                                                       // Эти тайм ауты можно не ставить
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


////////////////////////////////////////////////// Организация GUI и пакета данных для передачи в СОМ порт и передача данных ///////////////////////////////////////////////////////////////

        public void SerialSendButton_Click(object sender, EventArgs e)                          // При нажатии на кнопку отправки в СОМ порт:
        {
            int count = 1;                                                                      // Количество байтов массива для отправки в СОМ 
            int offset = 6;                                                                     // Смещение не нужно = 0
            byte[] buffer = new byte[] {DurationMassiveDataCH1[0], DurationMassiveDataCH1[1],   // Массив байтов для отправки в СОМ порт
                                        DelayMassiveDataCH1[0],    DelayMassiveDataCH1[1],
                                        DurMultiplierCH1,          DelMultiplierCH1,
                                        TypeStartCH1



                                                                                     };

            if (Port.IsOpen == true)                                                            // Если порт открыт 
            {
                if (DurTextBoxCh1.Text == "0" | DelTextBoxch1.Text == "0")
                {
                        MessageBox.Show("Введите значение больше 0", "Сообщение",               // Выводим сообщение призывающее выбрать СОМ порт
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
                        if (DurComboBoxCh1.Text == "" | DelComboBoxCh1.Text == "")             // Если текст боксы пустые выводим сообщение призывающее выбрать тип пуска
                        {
                            MessageBox.Show("Выберите диапазон длительности и задержки 'нс','мкс','мс','с'", "Сообщение",  
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                        }
                        else
                        {
                            Port.Write(buffer, offset, count);                                  // Осуществляем передачу байтов
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            int count = 1;
            int offset = 0;
            byte[] BufStart = new byte[] { 0 };                                                             // Какое число отправлять в качестве сигнала на ПУСК??? ОТВЕТ: "0"!!!

            if (Port.IsOpen == true)                                                            // Если порт открыт 
            {
                if (DurTextBoxCh1.Text == "0" | DelTextBoxch1.Text == "0")                                  //ПРОВЕРЬ ПЕРЕСЫЛКУ НУЛЯ ОТВЕТ: пересылка осуществляется нормально!!!
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
 
        private void DurComboBoxCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if  (DurComboBoxCh1.Text == "нс")
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

        private void DelComboBoxCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh1.Text == "нс")
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

        private void ComboBoxTypeStartCh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh1.Text == "Общий")
            {
                TypeStartCH1 = 0;
            }
            if (ComboBoxTypeStartCh1.Text == "От предыдущего")
            {
                TypeStartCH1 = 1;
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

        private void DurComboBoxCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DurComboBoxCh2.Text == "нс")
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

        private void DelComboBoxCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DelComboBoxCh2.Text == "нс")
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

        private void ComboBoxTypeStartCh2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxTypeStartCh2.Text == "Общий")
            {
                TypeStartCH1 = 0;
            }
            if (ComboBoxTypeStartCh2.Text == "От предыдущего")
            {
                TypeStartCH2 = 1;
            }
        }
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
    }


}





