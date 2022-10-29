/*
Console.WriteLine("EJERCICIO 1");
Console.WriteLine("TOMA DE NOTAS\n");
byte notas = 5;
double acumulador;
double sumador=0;
for (int i = 0; i < notas; i++)
{
    Console.WriteLine("Ingresa la nota #"+(i+1));
    acumulador = double.Parse(Console.ReadLine());
    sumador += acumulador;
}
double promedio = sumador / notas;
Console.WriteLine("\nel promedio de las notas es: " + promedio);
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 2");
Console.WriteLine("Tiempo de ciclistas\n");
Console.WriteLine("Ingrese el numero de ciclista a los cuales les va a tomar el tiempo\n");
byte ciclistas = byte.Parse(Console.ReadLine());
double segundos;
double sumador = 0;

byte i = 1;
while (i<=ciclistas)
{
    Console.WriteLine("ciclista #" + i + ", ingresa el tiempo de recorrido en segundos");
    segundos = double.Parse(Console.ReadLine());
    sumador += segundos;
    i++;
}
double promedio = sumador / ciclistas;
Console.WriteLine("\nel promedio de los tiempos es: " + promedio+" segundos");
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 3");
Console.WriteLine("TORNEO DE DEPORTES\n");
byte numero_equipos = 0;
double promediopart = 0;
byte partmujeresfutbol = 0;
byte parthombresfutbol = 0;
byte participantes_futbol = 0;
byte partmujeresBalon = 0;
byte parthombresBalon = 0;
byte participantes_balon = 0;
byte partmujeresvoleibol = 0;
byte parthombresvoleibol = 0;
byte participantes_voleibol = 0;

Console.WriteLine("\nDESEA INGRESAR EQUIPO SI/NO");
string repetir = Console.ReadLine();


while (repetir=="SI")
{
    Console.WriteLine("ELIGE LA CATEGORIA EN LA CUAL VAN A PARTICIPAR\n");
    Console.WriteLine("futbol=1");
    Console.WriteLine("baloncesto=2");
    Console.WriteLine("voleibol=3");
    byte categoria = byte.Parse(Console.ReadLine());

    if (categoria == 1)
    {
        Console.WriteLine("\nINGRESE EL NOMBRE DEL EQUIPO");
        string nombre_equipo = Console.ReadLine();
        Console.WriteLine("\nINGRESE LA CANTIDAD DE INTEGRANTES; min=8 y max=15");
        byte cantparticipantes = byte.Parse(Console.ReadLine());

        if (cantparticipantes < 8 || cantparticipantes > 15)
        {
            Console.WriteLine("RECUERDE QUE EL RANGO ES MINIMO 8 Y MAXIMO 15 PARTICIPANTES POR EQUIPO");
        }
        else
        {
            for (int i = 0; i < cantparticipantes; i++)
            {
                Console.WriteLine("\nParticipante #" + (i + 1) + ":");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("GENERO: ");
                Console.WriteLine("MASCULINO=1");
                Console.WriteLine("FEMENINO=2");
                byte GENERO = byte.Parse(Console.ReadLine());

                if (GENERO == 1)
                {
                    parthombresfutbol++;
                }
                else if (GENERO == 2)
                {
                    partmujeresfutbol++;
                }
            }
            participantes_futbol = (byte)(parthombresfutbol + partmujeresfutbol);
            numero_equipos++;
        }
    }
    else if (categoria == 2)
    {
        Console.WriteLine("\nINGRESE EL NOMBRE DEL EQUIPO");
        string nombre_equipo = Console.ReadLine();
        Console.WriteLine("\nINGRESE LA CANTIDAD DE INTEGRANTES; min=5 y max=12");
        byte cantparticipantes = byte.Parse(Console.ReadLine());

        if (cantparticipantes < 5 || cantparticipantes > 12)
        {
            Console.WriteLine("RECUERDE QUE EL RANGO ES MINIMO 5 Y MAXIMO 12 PARTICIPANTES POR EQUIPO");
        }
        else
        {
            for (int i = 0; i < cantparticipantes; i++)
            {
                Console.WriteLine("\nParticipante #" + (i + 1) + ":");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("GENERO: ");
                Console.WriteLine("MASCULINO=1");
                Console.WriteLine("FEMENINO=2");
                byte GENERO = byte.Parse(Console.ReadLine());

                if (GENERO == 1)
                {
                    parthombresBalon++;
                }
                else if (GENERO == 2)
                {
                    partmujeresBalon++;
                }
            }
            participantes_balon = (byte)(parthombresBalon + partmujeresBalon);
            numero_equipos++;
        }
    }
    else if (categoria == 3)
    {
        Console.WriteLine("\nINGRESE EL NOMBRE DEL EQUIPO");
        string nombre_equipo = Console.ReadLine();
        Console.WriteLine("\nINGRESE LA CANTIDAD DE INTEGRANTES; min=5 y max=12");
        byte cantparticipantes = byte.Parse(Console.ReadLine());

        if (cantparticipantes < 5 || cantparticipantes > 12)
        {
            Console.WriteLine("RECUERDE QUE EL RANGO ES MINIMO 5 Y MAXIMO 12 PARTICIPANTES POR EQUIPO");
        }
        else
        {
            for (int i = 0; i < cantparticipantes; i++)
            {
                Console.WriteLine("\nParticipante #" + (i + 1) + ":");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("GENERO: ");
                Console.WriteLine("MASCULINO=1");
                Console.WriteLine("FEMENINO=2");
                byte GENERO = byte.Parse(Console.ReadLine());

                if (GENERO == 1)
                {
                    parthombresvoleibol++;
                }
                else if (GENERO == 2)
                {
                    partmujeresvoleibol++;
                }
            }
            participantes_voleibol = (byte)(parthombresvoleibol + partmujeresvoleibol);
            numero_equipos++;
        }
    }

    Console.WriteLine("\nDESEA INGRESAR OTRO EQUIPO SI/NO");
    repetir = Console.ReadLine();
    byte totalparticipantes = (byte)(participantes_futbol + participantes_balon + participantes_voleibol);
    promediopart = totalparticipantes / numero_equipos;

}

Console.WriteLine("la cantidad de equipos registrados es:" + numero_equipos + " equipos");
Console.WriteLine("\nla cantidad de personas en la categoria FUTBOL SON :" + participantes_futbol + " personas");
Console.WriteLine("la cantidad de personas en la categoria BALONCESTO SON :" + participantes_balon + " personas");
Console.WriteLine("la cantidad de personas en la categoria VOLEIBOL SON :" + participantes_voleibol + " personas");
Console.WriteLine("el promedio de participantes registrados es:" + promediopart + " personas");
Console.WriteLine("\nla cantidad de hombres registrados en futbol son: " + parthombresfutbol + " hombres");
Console.WriteLine("la cantidad de mujeres registradas en futbol son: " + partmujeresfutbol + " mujeres");
Console.WriteLine("la cantidad de hombres registrados en baloncesto son: " + parthombresBalon + " hombres");
Console.WriteLine("la cantidad de mujeres registradas en baloncesto son: " + partmujeresBalon + " mujeres");
Console.WriteLine("la cantidad de hombres registrados en voleibol son: " + parthombresvoleibol + " hombres");
Console.WriteLine("la cantidad de mujeres registradas en voleibol son: " + partmujeresvoleibol + " mujeres");
*/

/*
Console.WriteLine("EJERCICIO 4");
Console.WriteLine("ESCUELA DE BALLET DE BELLAS ARTES\n");

Console.WriteLine("va a registrar un alumno en un curso SI/NO");
string ingreso = Console.ReadLine();

byte cant_niños_ceramica = 0;
byte cant_adultos_ceramica = 0;
byte numeros_inscritos_ceramica;
double ganancias_ceramica;
double ganancias_ceramica_niños;
byte cant_niños_fotografia = 0;
byte cant_adultos_fotografia = 0;
byte numeros_inscritos_fotografia;
double ganancias_fotografia;
double ganancias_fotografia_niños;
byte cant_niños_blandas = 0;
byte cant_adultos_blandas = 0;
byte numeros_inscritos_blandas;
double ganancias_blandas;
double ganancias_blandas_niños;



while (ingreso.Equals("SI"))
{
    Console.WriteLine("\nelige el curso en la cual se van a escribir");
    Console.WriteLine("ceramica=1");
    Console.WriteLine("fotografia=2");
    Console.WriteLine("artes blandas=3");
    byte curso = byte.Parse(Console.ReadLine());


    if (curso == 1)
    {
        Console.WriteLine("\ningrese si vas a ingresar un grupo de niños o adultos");
        Console.WriteLine("niños=1\nadultos=2");
        byte tipogrupo = byte.Parse(Console.ReadLine());
        if (tipogrupo==1)
        {
            Console.WriteLine("\ningrese la cantidad de niños,min=5 y max=10");
            byte cant = byte.Parse(Console.ReadLine());
            cant_niños_ceramica = (byte)(cant_niños_ceramica + cant);

        } else if (tipogrupo == 2)
        {
            Console.WriteLine("\ningrese la cantidad de adulto,min=5 y max=10");
            byte cant = byte.Parse(Console.ReadLine());
            cant_adultos_ceramica = (byte)(cant_adultos_ceramica + cant);
        }


    }
    else if (curso == 2)
    {
        Console.WriteLine("\ningrese si vas a ingresar un grupo de niños o adultos");
        Console.WriteLine("niños=1\nadultos=2");
        byte tipogrupo = byte.Parse(Console.ReadLine());
        if (tipogrupo == 1)
        {
            Console.WriteLine("\ningrese la cantidad de niños,min=5 y max=10");
            byte cant = byte.Parse(Console.ReadLine());
            cant_niños_fotografia = (byte)(cant_niños_fotografia + cant);

        }
        else if (tipogrupo == 2)
        {
            Console.WriteLine("\ningrese la cantidad de adulto,min=5 y max=10");
            byte cant = byte.Parse(Console.ReadLine());
            cant_adultos_fotografia = (byte)(cant_adultos_fotografia + cant);
        }
    }
    else if (curso == 3)
    {
        Console.WriteLine("\ningrese si vas a ingresar un grupo de niños o adultos");
        Console.WriteLine("niños=1\nadultos=2");
        byte tipogrupo = byte.Parse(Console.ReadLine());
        if (tipogrupo == 1)
        {
            Console.WriteLine("\ningrese la cantidad de niños,min=5 y max=10");
            byte cant = byte.Parse(Console.ReadLine());
            cant_niños_blandas = (byte)(cant_niños_blandas + cant);

        }
        else if (tipogrupo == 2)
        {
            Console.WriteLine("\ningrese la cantidad de adulto,min=5 y max=10");
            byte cant = byte.Parse(Console.ReadLine());
            cant_adultos_blandas = (byte)(cant_adultos_blandas + cant);
        }
    }



    Console.WriteLine("\nva a registrar otro alumno a un curso SI/NO");
    ingreso = Console.ReadLine();
}
numeros_inscritos_ceramica = (byte)(cant_niños_ceramica + cant_adultos_ceramica);
ganancias_ceramica = (cant_niños_ceramica * 60000) + (cant_adultos_ceramica * 120000);
ganancias_ceramica_niños = cant_niños_ceramica * 60000;

numeros_inscritos_fotografia = (byte)(cant_niños_fotografia + cant_adultos_fotografia);
ganancias_fotografia = (cant_niños_fotografia * 60000) + (cant_adultos_fotografia * 120000);
ganancias_fotografia_niños = cant_niños_fotografia * 60000;

numeros_inscritos_blandas = (byte)(cant_niños_blandas + cant_adultos_blandas);
ganancias_blandas = (cant_niños_blandas * 60000) + (cant_adultos_blandas * 120000);
ganancias_blandas_niños = cant_niños_blandas * 60000;

Console.WriteLine("\nNumero de inscritos en ceramica="+ numeros_inscritos_ceramica);
Console.WriteLine("GANACIAS EN CERAMICA= $" + ganancias_ceramica);
Console.WriteLine("GANACIAS DE LOS GRUPOS DE NIñOS EN CERAMICA= $" + ganancias_ceramica_niños);
Console.WriteLine("\nNumero de inscritos en fotografia=" + numeros_inscritos_fotografia);
Console.WriteLine("GANACIAS EN FOTOGRAFIA= $" + ganancias_fotografia);
Console.WriteLine("GANACIAS DE LOS GRUPOS DE NIñOS EN FOTOGRADIA= $" + ganancias_fotografia_niños);
Console.WriteLine("\nNumero de inscritos en artes blandas=" + numeros_inscritos_blandas);
Console.WriteLine("GANACIAS EN ARTES BLANDAS= $" + ganancias_blandas);
Console.WriteLine("GANACIAS DE LOS GRUPOS DE NIñOS EN ARTES BLANDAS= $" + ganancias_blandas_niños);

Console.ReadKey();
*/

