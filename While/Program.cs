/*
Console.WriteLine("Ejercicio 1");
Console.WriteLine("ESTADIO");
string boleta = "si";
int capacidad_estadio = 45000;
int contper = 1;
int conttribnort=0, conttribsur=0, conttriboriente=0, conttriboccidente=0;

Console.WriteLine("INGRESO DE BOLETAS\n");


while (boleta.Equals("si"))
{
    contper++;
    if (contper <= capacidad_estadio)
    {
        Console.WriteLine("ingrese el sector de la tribuna");
        Console.WriteLine("norte=1\nsur=2\noriente=3\noccidente=4\n");
        byte sector = byte.Parse(Console.ReadLine());
        if (sector == 1)
        {
            conttribnort++;
        }
        else if (sector == 2)
        {
            conttribsur++;
        }
        else if (sector == 3)
        {
            conttriboriente++;
        }
        else if (sector == 4)
        {
            conttriboccidente++;
        }
        else
        {
            Console.WriteLine("\ningresa una de las opciones");
            break;
        }

        Console.WriteLine("\nva ha vender otra boleta si/no");
        boleta = Console.ReadLine();
        if (boleta == "no")
        {
            Console.WriteLine("\nCantidad de personas= "+(contper-1)+" personas");
            Console.WriteLine("Tribuna norte= " + conttribnort + " personas");
            Console.WriteLine("Tribuna sur= " + conttribsur + " personas");
            Console.WriteLine("Tribuna oriente= " + conttriboriente + " personas");
            Console.WriteLine("Tribuna occidente= " + conttriboccidente + " personas");
            Console.Read();
        }

    }
    else
    {
        Console.WriteLine("\nlo siento,ya se alcazo la capacidad maxima en el estadio");
        Console.WriteLine("\nCantidad de personas= " + (contper-1) + " personas");
        Console.WriteLine("Tribuna norte= " + conttribnort + " personas");
        Console.WriteLine("Tribuna sur= " + conttribsur + " personas");
        Console.WriteLine("Tribuna oriente= " + conttriboriente + " personas");
        Console.WriteLine("Tribuna occidente= " + conttriboccidente + " personas");
        break;
        Console.Read();

    }
}
*/

/*
Console.WriteLine("Ejercicio 2");
Console.WriteLine("METRO");
int cantpersonasmetro = 0;
int cantpersonasbello = 0;
int Hbello = 0;
int Mbello = 0;
int Nbello = 0;
int cantpersonasjavier = 0;
int Hjavier = 0;
int Mjavier = 0;
int Njavier = 0;
int cantpersonasestrella = 0;
int Hestrella = 0;
int Mestrella = 0;
int Nestrella = 0;
string ingreso = "si";

while (ingreso.Equals("si"))
{
    Console.WriteLine("\nIndica la Estacion del metro a la que vas a entrar");
    Console.WriteLine("Estacion Bello=1");
    Console.WriteLine("Estacion San Javier=2");
    Console.WriteLine("Estacion La Estrella=3\n");

    byte estacion = byte.Parse(Console.ReadLine());
    if (estacion == 1)
    {
        cantpersonasbello++;
        Console.WriteLine("Indica tu genero");
        Console.WriteLine("Hombre=1");
        Console.WriteLine("Mujer=2");
        Console.WriteLine("Niño=3\n");
        byte genero = byte.Parse(Console.ReadLine());
        if (genero == 1)
        {
            Hbello++;
        }
        else if (genero == 2)
        {
            Mbello++;
        }
        else if (genero == 3)
        {
            Nbello++;
        }
        else
        {
            Console.WriteLine("Elige una de las opciones anteriores");
            break;
        }

    }
    else if (estacion == 2)
    {
        cantpersonasjavier++;
        Console.WriteLine("Indica tu genero");
        Console.WriteLine("Hombre=1");
        Console.WriteLine("Mujer=2");
        Console.WriteLine("Niño=3\n");
        byte genero = byte.Parse(Console.ReadLine());
        if (genero == 1)
        {
            Hjavier++;
        }
        else if (genero == 2)
        {
            Mjavier++;
        }
        else if (genero == 3)
        {
            Njavier++;
        }
        else
        {
            Console.WriteLine("Elige una de las opciones anteriores");
            break;
        }
    }
    else if (estacion == 3)
    {
        cantpersonasestrella++;
        Console.WriteLine("Indica tu genero");
        Console.WriteLine("Hombre=1");
        Console.WriteLine("Mujer=2");
        Console.WriteLine("Niño=3\n");
        byte genero = byte.Parse(Console.ReadLine());
        if (genero == 1)
        {
            Hestrella++;
        }
        else if (genero == 2)
        {
            Mestrella++;
        }
        else if (genero == 3)
        {
            Nestrella++;
        }
        else
        {
            Console.WriteLine("Elige una de las opciones anteriores");
            break;
        }
    }
    else
    {
        Console.WriteLine("Elige una de las opciones anteriores");
        break;
    }



    Console.WriteLine("Entras al metro si/no");
    ingreso = Console.ReadLine();
}



cantpersonasbello = Hbello + Mbello + Nbello;
cantpersonasjavier = Hjavier + Mjavier + Njavier;
cantpersonasestrella = Hestrella + Mestrella + Nestrella;

cantpersonasmetro = cantpersonasbello+ cantpersonasjavier+ cantpersonasestrella;

Console.WriteLine("total de personas en el metro="+ cantpersonasmetro+" personas");
Console.WriteLine("personas de la estacion bello=" + cantpersonasbello + " personas");
Console.WriteLine("Hombres=" + Hbello);
Console.WriteLine("Mujeres=" + Mbello);
Console.WriteLine("Niños=" + Nbello);
Console.WriteLine("");
Console.WriteLine("personas de la estacion san javier=" + cantpersonasjavier + " personas");
Console.WriteLine("Hombres=" + Hjavier);
Console.WriteLine("Mujeres=" + Mjavier);
Console.WriteLine("Niños=" + Njavier);
Console.WriteLine("");
Console.WriteLine("personas de la estacion la estrella=" + cantpersonasestrella + " personas");
Console.WriteLine("Hombres=" + Hestrella);
Console.WriteLine("Mujeres=" + Mestrella);
Console.WriteLine("Niños=" + Nestrella);
Console.WriteLine("");
Console.Read();
*/

/*
Console.WriteLine("Ejercicio 3");
Console.WriteLine("VACUNAS");
string preguntaini;
int cantidad_personas = 0;
byte edad = 0;
int niños = 0;
int jovenes_rango_12_a_17=0;
int jovenes_rango_18_a_25=0;
int adultos = 0;

Console.WriteLine("hola te vas a vacunar");
preguntaini = Console.ReadLine();
while (preguntaini.Equals("si"))
{
    cantidad_personas++;
    Console.WriteLine("Bienvenid@ a la vacunaton");
    Console.Write("ingresa tu edad: ");
    edad = byte.Parse(Console.ReadLine());
    if(edad < 12)
    {
        niños++;
    }
    else if (edad >= 12 && edad <= 17)
    {
        jovenes_rango_12_a_17++;
    }
    else if (edad >= 18 && edad <= 25)
    {
        jovenes_rango_18_a_25++;
    }
    else if (edad> 25 && edad <= 100)
    {
        adultos++;
    }
    else
    {
        Console.WriteLine("TU RANGO TIENE QUE ESTAR ENTRE 0 A 100 Años");
        break;

    }
    Console.WriteLine("");
    Console.WriteLine("hola te vas a vacunar");
    preguntaini = Console.ReadLine();
}

Console.WriteLine("");
Console.WriteLine("cantidad de personas vacunadas= " + cantidad_personas);
Console.WriteLine("niños= " + niños);
Console.WriteLine("Jovenes estre 12 y 17 años= " + jovenes_rango_12_a_17);
Console.WriteLine("Jovenes estre 18 y 25 años= " + jovenes_rango_18_a_25);
Console.WriteLine("adultos= " + adultos);
Console.Read();
*/

/*
Console.WriteLine("Ejercicio 4");
Console.WriteLine("TEATRO");
string preguntaini;
int cantidad_personas = 1;
int capacidad_teatro = 3;
byte edad = 0;
int niños_entre_5_8 = 0;
int niños_entre_9_18 = 0;
int jovenes_rango_19_a_30 = 0;
int adultos_rango_31_a_45 = 0;
int adultos_mayores_46 = 0;

Console.WriteLine("Bienvenido al teatro,vas a ingresar si/no");
preguntaini = Console.ReadLine();
while (preguntaini.Equals("si"))
{
    cantidad_personas++;
    if (cantidad_personas <= capacidad_teatro)
    {
        Console.WriteLine("");
        Console.Write("ingresa tu edad por favor: ");
        edad = byte.Parse(Console.ReadLine());
        if (edad >= 5 && edad <= 5)
        {
            niños_entre_5_8++;
        }
        else if (edad >= 9 && edad <= 18)
        {
            niños_entre_9_18++;
        }
        else if (edad >= 19 && edad <= 30)
        {
            jovenes_rango_19_a_30++;
        }
        else if (edad > 31 && edad <= 45)
        {
            adultos_rango_31_a_45++;
        }
        else if (edad > 46 && edad <= 100)
        {
            adultos_mayores_46++;
        }
        else
        {
            Console.WriteLine("TU RANGO TIENE QUE ESTAR ENTRE 0 A 100 Años");
            break;

        }
        Console.WriteLine("");
        Console.WriteLine("Bienvenido al teatro,vas a ingresar si/no");
        preguntaini = Console.ReadLine();
    }

}

int suma_ganancias_niños = (niños_entre_5_8 + niños_entre_9_18) * 20000;
int suma_ganancias_adultos = (jovenes_rango_19_a_30 + adultos_rango_31_a_45 + adultos_mayores_46) * 40000;
int total_ganacias = suma_ganancias_niños + suma_ganancias_adultos;
Console.WriteLine("");
Console.WriteLine("cantidad de personas en el teatro= " + (cantidad_personas-1)+" personas");
Console.WriteLine("niños entre 5 y 8 años= " + niños_entre_5_8);
Console.WriteLine("niños entre 9 y 18 años= " + niños_entre_9_18);
Console.WriteLine("Jovenes entre 19 y 30 años= " + jovenes_rango_19_a_30);
Console.WriteLine("adultos entre 31 y 45 años= " + adultos_rango_31_a_45);
Console.WriteLine("adultos mayores de 45= " + adultos_mayores_46);
Console.WriteLine("Ganacias= " + total_ganacias);
Console.Read();
*/

/*
Console.WriteLine("Ejercicio 5");
Console.WriteLine("MARATON");
Console.WriteLine("Vas a participar en la carrera si/no");
String participacion = Console.ReadLine();
byte genero = 0;
byte hombreaficionado = 0;
byte hombreElite = 0;
byte mujeraficionada = 0;
byte mujerElite = 0;
byte categoria;
int ganacias = 0;
while (participacion.Equals("si"))
{
    Console.WriteLine("ingresa su genero");
    Console.WriteLine("hombre=1");
    Console.WriteLine("mujer=2");
    genero = byte.Parse(Console.ReadLine());
    if (genero == 1)
    {
        Console.WriteLine("ingresa su categoria");
        Console.WriteLine("aficionado=1");
        Console.WriteLine("elite=2");
        categoria = byte.Parse(Console.ReadLine());
        if (categoria == 1)
        {
            hombreaficionado++;
            ganacias += 25000;
        } else if(categoria == 2)
        {
            hombreElite++;
            ganacias += 25000;
        }
        else
        {
            Console.WriteLine("eliga una de las 2 opciones");
            break;
        }

    }else if(genero == 2)
    {
        Console.WriteLine("ingresa su categoria");
        Console.WriteLine("aficionada=1");
        Console.WriteLine("elite=2");
        categoria = byte.Parse(Console.ReadLine());
        if (categoria == 1)
        {
            mujeraficionada++;
            ganacias += 25000;
        }
        else if (categoria == 2)
        {
            mujerElite++;
            ganacias += 25000;
        }
        else
        {
            Console.WriteLine("eliga una de las 2 opciones");
            break;
        }
    }
    else
    {
        Console.WriteLine("eliga una de las 2 opciones");
        break;
    }
    Console.WriteLine("Vas a participar en la carrera si/no");
    participacion = Console.ReadLine();
}


Console.WriteLine("\ncantidad de hombres aficionados " + hombreaficionado);
Console.WriteLine("cantidad de hombres elites " + hombreElite);
Console.WriteLine("cantidad de mujeres aficionadas " + mujeraficionada);
Console.WriteLine("cantidad de mujeres elites " + mujerElite);
Console.WriteLine("ganacias= $" + ganacias);
Console.Read();
*/

/*
Console.WriteLine("Ejercicio 6");
Console.WriteLine("SENASOFT");
int parejaspro = 0;
int parejasmul = 0;
int parejasred = 0;
int parejasman = 0;
Console.WriteLine("Vas a participar en SENASOFT si/no");
String participacion = Console.ReadLine();
while (participacion.Equals("si")){
    Console.WriteLine("ingresa tu categoria");
    Console.WriteLine("programacion=1");
    Console.WriteLine("multimedia=2");
    Console.WriteLine("redes=3");
    Console.WriteLine("mantenimiento=4");
    byte categoria = byte.Parse(Console.ReadLine());
    if (categoria == 1)
    {
        parejaspro++;
        Console.WriteLine("ingresa nombre del integrante # 1");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("ingresa nombre del integrante # 2");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("gracias\n");
    }
    else if(categoria == 2)
    {
        parejasmul++;
        Console.WriteLine("ingresa nombre del integrante # 1");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("ingresa nombre del integrante # 2");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("gracias\n");
    }
    else if (categoria == 3)
    {
        parejasred++;
        Console.WriteLine("ingresa nombre del integrante # 1");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("ingresa nombre del integrante # 2");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("gracias\n");
    }
    else if (categoria == 4)
    {
        parejasman++;
        Console.WriteLine("ingresa nombre del integrante # 1");
        string nombre1 = Console.ReadLine();
        Console.WriteLine("ingresa nombre del integrante # 2");
        string nombre2 = Console.ReadLine();
        Console.WriteLine("gracias\n");
    }
    else
    {
        Console.WriteLine("elige una de las opciones anteriores");
        break;
    }

    Console.WriteLine("Vas a participar en SENASOFT si/no");
    participacion = Console.ReadLine();

}

int cantidadper = (parejaspro + parejasmul + parejasred + parejasman) * 2;
Console.WriteLine("cantidad de parejas en categoria programacion= "+ parejaspro+" parejas");
Console.WriteLine("cantidad de parejas en categoria multimedia= " + parejasmul + " parejas");
Console.WriteLine("cantidad de parejas en categoria redes= " + parejasred + " parejas");
Console.WriteLine("cantidad de parejas en categoria mantenimiento= " + parejasman + " parejas");
Console.WriteLine("cantidad de personas en categoria SENASOFT= " + cantidadper + " parejas");
Console.Read();
*/

/*
Console.WriteLine("EJERCICIO 7");
Console.WriteLine("10 PRIMEROS PARES");

byte limite = 20;
byte CONT = 0;
while (CONT<=limite)
{
    if (CONT % 2 == 0)
    {
        Console.WriteLine("Numero #" + CONT);
    }
    CONT++;
}
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 8");
Console.WriteLine("10 PRIMEROS IMPARES");

byte limite = 20;
byte CONT = 0;
while (CONT <= limite)
{
    if (CONT % 2 != 0)
    {
        Console.WriteLine("Numero #" + CONT);
    }
    CONT++;
}
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 9");
Console.WriteLine("SUMA DE LOS 10 PRIMEROS IMPARES");

byte limite = 20;
byte CONT = 0;
int SUMA = 0;
while (CONT <= limite)
{
    if (CONT % 2 != 0)
    {
        SUMA = SUMA + CONT;
    }
    CONT++;


}
Console.WriteLine("LA SUMA EQUIVALE A " + SUMA);
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 10");
Console.WriteLine("SUMA DE LOS 10 PRIMEROS PARES");

byte limite = 20;
byte CONT = 0;
int SUMA = 0;
while (CONT <= limite)
{
    if (CONT % 2 == 0)
    {
        SUMA = SUMA + CONT;
    }
    CONT++;
}
Console.WriteLine("LA SUMA EQUIVALE A " + SUMA);
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 11");
Console.WriteLine("obtener la tabla de multiplicar");

Console.WriteLine("ingresa el numero al cual quieres explortar la tabla de multiplicar");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(" ");

byte cont = 0;

while (cont<=10)
{
    int resp = num * cont;
    Console.WriteLine(num+" X "+ cont+" = "+ resp);
    cont++;
}
*/

/*
Console.WriteLine("EJERCICIO 12");
byte cont1 = 0;
byte cont2;
while (cont1 < 4)
{ 
    cont2 = 0;
    while (cont2<3)
    {
        Console.WriteLine("el valor de la variable "+ cont1+ cont2);
        cont2++;

    }
cont1++;

}
Console.ReadKey();
*/

/*
Console.WriteLine("EJERCICIO 13");
Console.WriteLine("frecuencia fibonachi");
Console.WriteLine("INGRESA LA CANTIDAD DE NUMEROS QUE QUIERES IMPRIMIR");
int numeros = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.WriteLine("FRECUENCIA");
int cont = 1;
int a = 0;
int b = 1;
while (cont<= numeros)
{
    if (cont % 2==1)
    {
        Console.WriteLine(a);
        a = a + b;
    }
    else
    {
        Console.WriteLine(b);
        b = b + a;
    }
    cont++;
}
Console.Read();
*/

