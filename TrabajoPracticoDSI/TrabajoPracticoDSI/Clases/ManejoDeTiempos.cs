using System;
using System.Globalization;
using System.Windows.Forms;

namespace TrabajoPracticoDSI.Clase
{
    class ManejoDeTiempos
    {
        public string FormatearIntMilitarAString(int IntMilitar)
        {
            ///<summary>Convierte un int a un string de cuatro digitos agregando tantos ceros como haga falta</summary>
            string StringMilitar = IntMilitar.ToString();
            if (StringMilitar.Length > 4) { return ""; }

            if (StringMilitar.Length == 3)
                StringMilitar = $"0{StringMilitar}";

            if (StringMilitar.Length == 2)
                StringMilitar = $"00{StringMilitar}";

            if (StringMilitar.Length == 1)
                StringMilitar = $"000{StringMilitar}";

            return $"{StringMilitar[0]}{StringMilitar[1]}:{StringMilitar[2]}{StringMilitar[3]}hs";
        }

        public Array separarMindeHoras(int horario)
        {
            /// <summary>Separa un int militar en un array compuesto de horas y minutos </summary>
            string horariodeString = FormatearIntMilitarAString(horario);
            string horasDelHorario = $"{horariodeString[0]}{horariodeString[1]}";
            string minutosDelHorario = $"{horariodeString[3]}{horariodeString[4]}";

            int horasDelHorarioInt = Int32.Parse(horasDelHorario);
            int minutosDelHorarioInt = Int32.Parse(minutosDelHorario);

            int[] horarioFinal = new int[] { horasDelHorarioInt, minutosDelHorarioInt };

            return horarioFinal;
        }

        public bool ValidarHorario(int horario, bool horarioDefasado)
        {
            ///<summary>Se encarga de verificar que un horario de formato "hh:mm" 
            ///no pueda contener horas mayores a 23 y minutos mayores a 59</summary>

            Array horarioSeparado = separarMindeHoras(horario);

            int horasDelHorarioInt = (int)horarioSeparado.GetValue(0);
            int minutosDelHorarioInt = (int)horarioSeparado.GetValue(1);

            if (horasDelHorarioInt > 23 || minutosDelHorarioInt > 59)
            { horarioDefasado = true; }

            return horarioDefasado;
        }

        public bool esHorarioValido(string horario)
        {
            /// Retorna si un horario en string es válido para ser convertido a DateTime
            // El formato debe ser "hh:mm"
            if (horario.Length != 5) return false;

            string horasDelHorario = $"{horario[0]}{horario[1]}";
            string minutosDelHorario = $"{horario[3]}{horario[4]}";

            int minutosInt = Int32.Parse(minutosDelHorario);
            int horasInt = Int32.Parse(horasDelHorario);

            if (minutosInt > 59) return false;
            if (horasInt > 23) return false;

            return true;
        }

        public int ValidarMinutos(int horario)
        {
            Array horarioSeparado = separarMindeHoras(horario);

            int horasDelHorarioInt = (int)horarioSeparado.GetValue(0);
            int minutosDelHorarioInt = (int)horarioSeparado.GetValue(1);

            if (minutosDelHorarioInt > 59)
            {
                horasDelHorarioInt = minutosDelHorarioInt / 60;
                minutosDelHorarioInt = minutosDelHorarioInt % 60;

                string horasdelHorarioString = horasDelHorarioInt.ToString();
                string minutosdelHorarioString = minutosDelHorarioInt.ToString();

                string horariofinal = horasdelHorarioString + minutosdelHorarioString;
                int horariofinalInt = Int32.Parse(horariofinal);
                return horariofinalInt;
            };

            return horario;
        }

        public int convertirAIntMilitar(string horario)
        {
            // Suponiendo que tenemos un horario X, convertimos esto en un horario militar.
            // Ej: 01:40hs = 0140 
            string horasDelHorario = $"{horario[0]}{horario[1]}"; // 01
            string minutosDelHorario = $"{horario[3]}{horario[4]}"; // 40

            string temp = $"{horasDelHorario}{minutosDelHorario}"; // 0140
            try
            {

                return Int32.Parse(temp); // -> convierto a int
            }
            catch (Exception)
            {
                MessageBox.Show("Error al hacer Parse de string a int");
                return 0;
            }
        }

        public int calcularDiferenciaDelDia(string horarioInicial, string horarioFinal)
        {
            // Retorna int militar con la diferencia de dos horarios 
            DateTime InicialDateTime = ParseTime(horarioInicial);
            DateTime FinalDateTime = ParseTime(horarioFinal);

            string horario = RestarDateTimes(InicialDateTime.AddHours(24), FinalDateTime);
            int diferenciaDelDia = convertirAIntMilitar(horario);
            return diferenciaDelDia;
        }

        public TimeSpan calcularDiferenciaDelDiaDateTimes(DateTime horarioInicial, DateTime horarioFinal)
        {
            // Calcula la diferencia del dia cuando el horario final es menor que el horario inicial
            // Ej: Inicial = 15:00 | Final = 14:00 => nos devuelve 23:00 hs de diferencia
            return horarioFinal.Subtract(horarioInicial.AddHours(24));
        }

        public string RestarDateTimes(string horaFinal, string horaInicial)
        {
            /// <summary> Toma dos strings de horarios en formato "HH:MM" y retorna un Objeto TimeSpan con la resta de los tiempos </summary>
            DateTime final = ParseTime(horaFinal);
            DateTime inicial = ParseTime(horaInicial);

            string Tiempo = $"{final.Subtract(inicial)}";
            // Lo de arriba devuelve en formato "hh:mm:ss" con el substring lo dividimos para que solo nos de "hh:mm"
            string HorasYMinutos = Tiempo.Substring(0, 5);

            return HorasYMinutos;
        }

        public string RestarDateTimes(DateTime horaFinal, DateTime horaInicial)
        {
            /// <summary> Toma dos datetimes, los resta y devuelve un string con el resultado </summary>

            string Tiempo = $"{horaFinal.Subtract(horaInicial)}";
            string HorasYMinutos = Tiempo.Substring(0, 5);

            return HorasYMinutos;
        }

        // Funcion lambda que convierte un formato de horas y minutos a un objeto DateTime 
        // El parametro tiene que seguir la siguiente estructura:  "14:00" 
        // Documentación oficial del método: https://docs.microsoft.com/en-us/dotnet/api/system.datetime.parseexact?view=net-5.0
        public DateTime ParseTime(string horasYMin) => DateTime.ParseExact(horasYMin, "HH:mm", null, System.Globalization.DateTimeStyles.None);
        public DateTime ParseTime(int horasYMin) => DateTime.ParseExact(horasYMin.ToString(), "HH:mm", null, System.Globalization.DateTimeStyles.None);
    }
}