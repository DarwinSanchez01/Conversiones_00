using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Datos();
            Console.ReadLine();
        }
        static void Datos()
        {
        regresar1:
            int opc, opcL, opcL1;
            do
            {
                Console.Write("1. Longitud\n2. Masa\n3. Volumen\nElija una opcion  : ");
                opc = int.Parse(Console.ReadLine()); Console.Clear();
            } while (opc < 1 || opc > 3);

            switch (opc)
            {
                case 1:
                regreso:
                    do
                    {
                        Console.WriteLine("Unidades de Longitud");
                        Console.Write("1.  Kilometro\n2.  Metro\n3.  Centimetro\n4.  Milimetro\n5.  Yarda\n6.  Pie\n7.  Pulgada\n8.  Salir\n9.  Atras\nElija una opcion  :   ");
                        opcL = int.Parse(Console.ReadLine()); Console.Clear();
                    } while (opcL < 1 || opcL > 9);
                    switch (opcL)
                    {
                        case 1:
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Metro\n2.  Centimetro\n3.  Milimetro\n4.  Yarda\n5.  Pie\n6.  Pulgada\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 >= 9);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            double kil;
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese los Kilometros :  ");
                                    kil = double.Parse(Console.ReadLine());
                                    Kil_a_Metro(kil);
                                    break;
                                case 2:
                                    Console.Write("Ingrese los Kilometros :  ");
                                    kil = double.Parse(Console.ReadLine());
                                    Kil_a_Cm(kil);
                                    break;
                                case 3:
                                    Console.Write("Ingrese los Kilometros :  ");
                                    kil = double.Parse(Console.ReadLine());
                                    Kil_a_Mm(kil);
                                    break;
                                case 4:
                                    Console.Write("Ingrese los Kilometros :  ");
                                    kil = double.Parse(Console.ReadLine());
                                    Kil_a_Yd(kil);
                                    break;
                                case 5:
                                    Console.Write("Ingrese los Kilometros :  ");
                                    kil = double.Parse(Console.ReadLine());
                                    Kil_a_Pie(kil);
                                    break;
                                case 6:
                                    Console.Write("Ingrese los Kilometros :  ");
                                    kil = double.Parse(Console.ReadLine());
                                    Kil_a_Pul(kil);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 2:
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilometro\n2.  Centimetro\n3.  Milimetro\n4.  Yarda\n5.  Pie\n6.  Pulgada\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 8);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            double mt;
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese los Metros :  ");
                                    mt = double.Parse(Console.ReadLine());
                                    Mt_a_Kil(mt);
                                    break;
                                case 2:
                                    Console.Write("Ingrese los Metros :  ");
                                    mt = double.Parse(Console.ReadLine());
                                    Mt_a_Cm(mt);
                                    break;
                                case 3:
                                    Console.Write("Ingrese los Metros :  ");
                                    mt = double.Parse(Console.ReadLine());
                                    Mt_a_Mm(mt);
                                    break;
                                case 4:
                                    Console.Write("Ingrese los Metros :  ");
                                    mt = double.Parse(Console.ReadLine());
                                    Mt_a_Yd(mt);
                                    break;
                                case 5:
                                    Console.Write("Ingrese los Metros :  ");
                                    mt = double.Parse(Console.ReadLine());
                                    Mt_a_Pie(mt);
                                    break;
                                case 6:
                                    Console.Write("Ingrese los Metros :  ");
                                    mt = double.Parse(Console.ReadLine());
                                    Mt_a_Pul(mt);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 3:
                            double cm;
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilometro\n2.  Metro\n3.  Milimetro\n4.  Yarda\n5.  Pie\n6.  Pulgada\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 8);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese los centimetros :  ");
                                    cm = double.Parse(Console.ReadLine());
                                    Cm_a_Km(cm);
                                    break;
                                case 2:
                                    Console.Write("Ingrese los centimetros :  ");
                                    cm = double.Parse(Console.ReadLine());
                                    Cm_a_Mt(cm);
                                    break;
                                case 3:
                                    Console.Write("Ingrese los centimetros :  ");
                                    cm = double.Parse(Console.ReadLine());
                                    Cm_a_Mm(cm);
                                    break;
                                case 4:
                                    Console.Write("Ingrese los centimetros :  ");
                                    cm = double.Parse(Console.ReadLine());
                                    Cm_a_Yd(cm);
                                    break;
                                case 5:
                                    Console.Write("Ingrese los centimetros :  ");
                                    cm = double.Parse(Console.ReadLine());
                                    Cm_a_Pie(cm);
                                    break;
                                case 6:
                                    Console.Write("Ingrese los centimetros :  ");
                                    cm = double.Parse(Console.ReadLine());
                                    Cm_a_Pul(cm);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 4:
                            double mm;
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilometro\n2.  Metro\n3.  Centimetro\n4.  Yarda\n5.  Pie\n6.  Pulgada\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 8);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese los milimetros :  ");
                                    mm = double.Parse(Console.ReadLine());
                                    Mm_a_Km(mm);
                                    break;
                                case 2:
                                    Console.Write("Ingrese los milimetros :  ");
                                    mm = double.Parse(Console.ReadLine());
                                    Mm_a_Mt(mm);
                                    break;
                                case 3:
                                    Console.Write("Ingrese los milimetros :  ");
                                    mm = double.Parse(Console.ReadLine());
                                    Mm_a_Cm(mm);
                                    break;
                                case 4:
                                    Console.Write("Ingrese los milimetros :  ");
                                    mm = double.Parse(Console.ReadLine());
                                    Mm_a_Yd(mm);
                                    break;
                                case 5:
                                    Console.Write("Ingrese los milimetros :  ");
                                    mm = double.Parse(Console.ReadLine());
                                    Mm_a_Pie(mm);
                                    break;
                                case 6:
                                    Console.Write("Ingrese los milimetros :  ");
                                    mm = double.Parse(Console.ReadLine());
                                    Mm_a_Pul(mm);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 5:
                            double yd;
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilometro\n2.  Metro\n3.  Centimetro\n4.  Milimetro\n5.  Pie\n6.  Pulgada\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 8);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese las Yardas :  ");
                                    yd = double.Parse(Console.ReadLine());
                                    Yd_a_Km(yd);
                                    break;
                                case 2:
                                    Console.Write("Ingrese las Yardas :  ");
                                    yd = double.Parse(Console.ReadLine());
                                    Yd_a_Mt(yd);
                                    break;
                                case 3:
                                    Console.Write("Ingrese las Yardas :  ");
                                    yd = double.Parse(Console.ReadLine());
                                    Yd_a_Cm(yd);
                                    break;
                                case 4:
                                    Console.Write("Ingrese las Yardas :  ");
                                    yd = double.Parse(Console.ReadLine());
                                    Yd_a_Mm(yd);
                                    break;
                                case 5:
                                    Console.Write("Ingrese las Yardas :  ");
                                    yd = double.Parse(Console.ReadLine());
                                    Yd_a_Pie(yd);
                                    break;
                                case 6:
                                    Console.Write("Ingrese las Yardas :  ");
                                    yd = double.Parse(Console.ReadLine());
                                    Yd_a_Pul(yd);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 6:
                            double pie;
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilometro\n2.  Metro\n3.  Centimetro\n4.  Milimetro\n5.  Yarda\n6.  Pulgada\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 8);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese los Pies :  ");
                                    pie = double.Parse(Console.ReadLine());
                                    Pie_a_Km(pie);
                                    break;
                                case 2:
                                    Console.Write("Ingrese los Pies :  ");
                                    pie = double.Parse(Console.ReadLine());
                                    Pie_a_Mt(pie);
                                    break;
                                case 3:
                                    Console.Write("Ingrese los Pies :  ");
                                    pie = double.Parse(Console.ReadLine());
                                    Pie_a_Cm(pie);
                                    break;
                                case 4:
                                    Console.Write("Ingrese los Pies :  ");
                                    pie = double.Parse(Console.ReadLine());
                                    Pie_a_Mm(pie);
                                    break;
                                case 5:
                                    Console.Write("Ingrese los Pies :  ");
                                    pie = double.Parse(Console.ReadLine());
                                    Pie_a_Yd(pie);
                                    break;
                                case 6:
                                    Console.Write("Ingrese los Pies :  ");
                                    pie = double.Parse(Console.ReadLine());
                                    Pie_a_Pul(pie);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 7:
                            double pul;
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilometro\n2.  Metro\n3.  Centimetro\n4.  Milimetro\n5.  Yarda\n6.  Pie\n7.  Salir\n8.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 8);
                            if (opcL1 == 8)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Console.Write("Ingrese las pulgadas :  ");
                                    pul = double.Parse(Console.ReadLine());
                                    Pul_a_Km(pul);
                                    break;
                                case 2:
                                    Console.Write("Ingrese las pulgadas :  ");
                                    pul = double.Parse(Console.ReadLine());
                                    Pul_a_Mt(pul);
                                    break;
                                case 3:
                                    Console.Write("Ingrese las pulgadas :  ");
                                    pul = double.Parse(Console.ReadLine());
                                    Pul_a_Cm(pul);
                                    break;
                                case 4:
                                    Console.Write("Ingrese las pulgadas :  ");
                                    pul = double.Parse(Console.ReadLine());
                                    Pul_a_Mm(pul);
                                    break;
                                case 5:
                                    Console.Write("Ingrese las pulgadas :  ");
                                    pul = double.Parse(Console.ReadLine());
                                    Pul_a_Yd(pul);
                                    break;
                                case 6:
                                    Console.Write("Ingrese las pulgadas :  ");
                                    pul = double.Parse(Console.ReadLine());
                                    Pul_a_Pie(pul);
                                    break;
                                case 7:
                                    break;
                            }
                            break;
                        case 8:
                            break;
                        case 9:
                            goto regresar1;
                    }
                    break;
                case 2:
                    //Kilogramos, gramos, Miligramos, Libra, tonelada
                    do
                    {
                        Console.WriteLine("Unidades de Masa");
                        Console.Write("1.  Kilogramos\n2.  Gramos\n3.  Miligramos\n4.  Libras\n5.  Toneladas\n6.  Salir\n7.  Atras\nElija una opcion  :   ");
                        opcL = int.Parse(Console.ReadLine()); Console.Clear();
                    } while (opcL < 1 || opcL > 7);
                    switch (opcL)
                    {
                        case 1:
                            Console.WriteLine("Ingrese los kilogramos :  ");
                            double kg = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Gramos\n2.  Miligramos\n3.  Libras\n4.  Toneladas\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Kg_a_Gr(kg);
                                    break;
                                case 2:
                                    Kg_a_Mg(kg);
                                    break;
                                case 3:
                                    Kg_a_Lb(kg);
                                    break;
                                case 4:
                                    Kg_a_Tn(kg);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese los gramos :  ");
                            double gr = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilogramos\n2.  Miligramos\n3.  Libras\n4.  Toneladas\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Gr_a_Kg(gr);
                                    break;
                                case 2:
                                    Gr_a_Mg(gr);
                                    break;
                                case 3:
                                    Gr_a_Lb(gr);
                                    break;
                                case 4:
                                    Gr_a_Tn(gr);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese los miligramos :  ");
                            double mg = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilogramos\n2.  Gramos\n3.  Libras\n4.  Toneladas\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Mg_a_Kg(mg);
                                    break;
                                case 2:
                                    Mg_a_Gr(mg);
                                    break;
                                case 3:
                                    Mg_a_Lb(mg);
                                    break;
                                case 4:
                                    Mg_a_Tn(mg);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Ingrese las libras :  ");
                            double lb = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilogramos\n2.  Gramos\n3.  Miligramos\n4.  Toneladas\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Lb_a_Kg(lb);
                                    break;
                                case 2:
                                    Lb_a_Gr(lb);
                                    break;
                                case 3:
                                    Lb_a_Mg(lb);
                                    break;
                                case 4:
                                    Lb_a_Tn(lb);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Ingrese las toneladas :  ");
                            double tn = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Kilogramos\n2.  Gramos\n3.  Miligramos\n4.  Libras\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Tn_a_Kg(tn);
                                    break;
                                case 2:
                                    Tn_a_Gr(tn);
                                    break;
                                case 3:
                                    Tn_a_Mg(tn);
                                    break;
                                case 4:
                                    Tn_a_Lb(tn);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 6:
                            break;
                        case 7:
                            goto regresar1;
                    }
                    break;
                case 3:
                    do
                    {
                        Console.WriteLine("Unidades de Volumen");
                        Console.Write("1.  Litros\n2.  Mililitros\n3.  Galones\n4.  Metros Cubicos\n5.  Centimetros Cubicos\n6.  Salir\n7.  Atras\nElija una opcion  :   ");
                        opcL = int.Parse(Console.ReadLine()); Console.Clear();
                    } while (opcL < 1 || opcL > 7);
                    switch (opcL)
                    {
                        case 1:
                            Console.WriteLine("Ingrese las litros :  ");
                            double lt = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Mililitros\n2.  Galones\n3.  Metros Cubicos\n4.  Centimetros Cubicos\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Lt_a_Ml(lt);
                                    break;
                                case 2:
                                    Lt_a_Gl(lt);
                                    break;
                                case 3:
                                    Lt_a_Mtcu(lt);
                                    break;
                                case 4:
                                    Lt_a_Cmcu(lt);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese las mililitros :  ");
                            double ml = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Litros\n2.  Galones\n3.  Metros Cubicos\n4.  Centimetros Cubicos\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Ml_a_Lt(ml);
                                    break;
                                case 2:
                                    Ml_a_Gl(ml);
                                    break;
                                case 3:
                                    Ml_a_Mtcu(ml);
                                    break;
                                case 4:
                                    Ml_a_Cmcu(ml);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese las galones :  ");
                            double gl = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Litros\n2.  Mililitros\n3.  Metros Cubicos\n4.  Centimetros Cubicos\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Gl_a_Lt(gl);
                                    break;
                                case 2:
                                    Gl_a_Ml(gl);
                                    break;
                                case 3:
                                    Gl_a_Mtcu(gl);
                                    break;
                                case 4:
                                    Gl_a_Cmcu(gl);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("Ingrese las metros cubicos :  ");
                            double mcu = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Litros\n2.  Mililitros\n3.  Galones\n4.  Centimetros Cubicos\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Mtcu_a_Lt(mcu);
                                    break;
                                case 2:
                                    Mtcu_a_Ml(mcu);
                                    break;
                                case 3:
                                    Mtcu_a_Gl(mcu);
                                    break;
                                case 4:
                                    Mtcu_a_Cmc(mcu);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 5:
                            Console.WriteLine("Ingrese las centimetros cubicos :  ");
                            double cmcu = int.Parse(Console.ReadLine());
                            Console.WriteLine("");
                            do
                            {
                                Console.WriteLine("A que lo desea convertir");
                                Console.Write("1.  Litros\n2.  Mililitros\n3.  Galones\n4.  Metros Cubicos\n5.  Salir\n6.  Atras\nElija una opcion  :   ");
                                opcL1 = int.Parse(Console.ReadLine()); Console.Clear();
                            } while (opcL1 < 1 || opcL1 > 6);
                            if (opcL1 == 6)
                            {
                                goto regreso;
                            }
                            switch (opcL1)
                            {
                                case 1:
                                    Cmc_a_Lt(cmcu);
                                    break;
                                case 2:
                                    Cmc_a_Ml(cmcu);
                                    break;
                                case 3:
                                    Cmc_a_Gl(cmcu);
                                    break;
                                case 4:
                                    Cmc_a_mcu(cmcu);
                                    break;
                                case 5:
                                    break;
                            }
                            break;
                        case 6:
                            break;
                        case 7:
                            goto regresar1;
                    }
                    break;
            }
            Console.Write("Desea volver al inicio (S/s)  :   ");
            string op = Console.ReadLine();
            if (op == "s" || op == "S")
            {
                Console.Clear();
                goto regresar1;
            }
            else
            {
                Console.WriteLine("Cerrando el programa . . .");
            }
        }
        static void Kil_a_Metro(double kil)
        {
            double result = kil * (1000 / 1);
            Console.WriteLine("{0} Km a mts es :   {1} mts\n", kil, result);
        }
        static void Kil_a_Cm(double kil)
        {
            double result = (kil * (1000 / 1) * (100 / 1));
            Console.WriteLine("{0} Km a cm es :   {1} cm\n", kil, result);
        }
        static void Kil_a_Mm(double kil)
        {
            double result = (kil * (1000 / 1) * (100 / 1) * (10 / 1));
            Console.WriteLine("{0} Km a mm es :   {1} mm\n", kil, result);
        }
        static void Kil_a_Yd(double kil)
        {
            double result = kil * (1000 / 1) * (100 / 1) * (1 / 91.44);
            Console.WriteLine("{0} Km a yd es :   {1} yd\n", kil, result);
        }
        static void Kil_a_Pie(double kil)
        {
            double result = kil * (1000 / 1) * (100 / 1) * (1 / 30.48);
            Console.WriteLine("{0} Km a pie es :   {1} pies\n", kil, result);
        }
        static void Kil_a_Pul(double kil)
        {
            double result = kil * (1000 / 1) * (100 / 1) * (1 / 2.54);
            Console.WriteLine("{0} Km a pulg es :   {1} pulg\n", kil, result);
        }
        static void Mt_a_Kil(double mt)
        {
            double result = mt / 1000;
            Console.WriteLine($"{mt} mtrs a km es :   {result} km\n");
        }
        static void Mt_a_Cm(double mt)
        {
            double result = mt * 100;
            Console.WriteLine("{0} mtrs a cm es :   {1} cm\n", mt, result);
        }
        static void Mt_a_Mm(double mt)
        {
            double result = mt * 100 * 10;
            Console.WriteLine("{0} mtrs a mm es :   {1} mm\n", mt, result);
        }
        static void Mt_a_Yd(double mt)
        {
            double result = mt * 100 * 1 / 91.44;
            Console.WriteLine("{0} mtrs a yd es :   {1} yd\n", mt, result);
        }
        static void Mt_a_Pie(double mt)
        {
            double result = mt * 100 * 1 / 30.48;
            Console.WriteLine("{0} mtrs a pie es :   {1} pie\n", mt, result);
        }
        static void Mt_a_Pul(double mt)
        {
            double result = mt * 100 * 1 / 2.54;
            Console.WriteLine("{0} mtrs a pul es :   {1} pul\n", mt, result);
        }
        static void Cm_a_Km(double cm)
        {
            double result = cm / 100 * 1 / 1000;
            Console.WriteLine("{0} cm a km es :   {1} km\n", cm, result);
        }
        static void Cm_a_Mt(double cm)
        {
            double result = cm / 100;
            Console.WriteLine("{0} cm a mt es :   {1} mt\n", cm, result);
        }
        static void Cm_a_Mm(double cm)
        {
            double result = cm * 10;
            Console.WriteLine("{0} cm a mm es :   {1} mm\n", cm, result);
        }
        static void Cm_a_Yd(double cm)
        {
            double result = cm / 91.44;
            Console.WriteLine("{0} cm a yd es :   {1} yd\n", cm, result);
        }
        static void Cm_a_Pie(double cm)
        {
            double result = cm / 30.48;
            Console.WriteLine("{0} cm a pie es :   {1} pie\n", cm, result);
        }
        static void Cm_a_Pul(double cm)
        {
            double result = cm / 2.54;
            Console.WriteLine("{0} cm a pul es :   {1} pul\n", cm, result);
        }
        static void Mm_a_Km(double mm)
        {
            double result = mm / 10 * 1 / 100 * 1 / 1000;
            Console.WriteLine("{0} mm a km es :   {1} km\n", mm, result);
        }
        static void Mm_a_Mt(double mm)
        {
            double result = mm / 10 * 1 / 100;
            Console.WriteLine("{0} mm a mt es :   {1} mt\n", mm, result);
        }
        static void Mm_a_Cm(double mm)
        {
            double result = mm / 10;
            Console.WriteLine("{0} mm a cm es :   {1} cm\n", mm, result);
        }
        static void Mm_a_Yd(double mm)
        {
            double result = mm / 10 * 1 / 91.44;
            Console.WriteLine("{0} mm a yd es :   {1} yd\n", mm, result);
        }
        static void Mm_a_Pie(double mm)
        {
            double result = mm / 10 * 1 / 30.48;
            Console.WriteLine("{0} mm a pie es :   {1} pie\n", mm, result);
        }
        static void Mm_a_Pul(double mm)
        {
            double result = mm / 10 * 1 / 2.54;
            Console.WriteLine("{0} mm a pul es :   {1} pul\n", mm, result);
        }
        static void Yd_a_Km(double yd)
        {
            double result = yd * 91.44 * 1 / 100 * 1 / 1000;
            Console.WriteLine("{0} yd a km es :   {1} km\n", yd, result);
        }
        static void Yd_a_Mt(double yd)
        {
            double result = yd * 91.44 * 1 / 100;
            Console.WriteLine("{0} yd a mt es :   {1} mt\n", yd, result);
        }
        static void Yd_a_Cm(double yd)
        {
            double result = yd * 91.44;
            Console.WriteLine("{0} yd a cm es :   {1} cm\n", yd, result);
        }
        static void Yd_a_Mm(double yd)
        {
            double result = yd * 91.44 * 10 / 1;
            Console.WriteLine("{0} yd a mm es :   {1} mm\n", yd, result);
        }
        static void Yd_a_Pie(double yd)
        {
            double result = yd * 91.44 * 1 / 30.48;
            Console.WriteLine("{0} yd a pie es :   {1} pie\n", yd, result);
        }
        static void Yd_a_Pul(double yd)
        {
            double result = yd * 91.44 * 1 / 2.54;
            Console.WriteLine("{0} yd a pul es :   {1} pul\n", yd, result);
        }
        static void Pie_a_Km(double pie)
        {
            double result = pie * 30.48 * 1 / 100 * 1 / 1000;
            Console.WriteLine("{0} pie a km es :   {1} km\n", pie, result);
        }
        static void Pie_a_Mt(double pie)
        {
            double result = pie * 30.48 * 1 / 100;
            Console.WriteLine("{0} pie a mt es :   {1} mt\n", pie, result);
        }
        static void Pie_a_Cm(double pie)
        {
            double result = pie * 30.48;
            Console.WriteLine("{0} pie a cm es :   {1} cm\n", pie, result);
        }
        static void Pie_a_Mm(double pie)
        {
            double result = pie * 30.48 * 10;
            Console.WriteLine("{0} pie a mm es :   {1} mm\n", pie, result);
        }
        static void Pie_a_Yd(double pie)
        {
            double result = pie * 30.48 * 1 / 91.44;
            Console.WriteLine("{0} pie a yd es :   {1} yd\n", pie, result);
        }
        static void Pie_a_Pul(double pie)
        {
            double result = pie * 30.48 * 1 / 2.54;
            Console.WriteLine("{0} pie a pul es :   {1} pul\n", pie, result);
        }
        static void Pul_a_Km(double pul)
        {
            double result = pul * 2.54 * 1 / 100 * 1 / 1000;
            Console.WriteLine("{0} pul a km es :   {1} km\n", pul, result);
        }
        static void Pul_a_Mt(double pul)
        {
            double result = pul * 2.54 * 1 / 100;
            Console.WriteLine("{0} pul a mt es :   {1} mt\n", pul, result);
        }
        static void Pul_a_Cm(double pul)
        {
            double result = pul * 2.54;
            Console.WriteLine("{0} pul a cm es :   {1} cm\n", pul, result);
        }
        static void Pul_a_Mm(double pul)
        {
            double result = pul * 2.54 * 10;
            Console.WriteLine("{0} pul a mm es :   {1} mm\n", pul, result);
        }
        static void Pul_a_Yd(double pul)
        {
            double result = pul * 2.54 * 1 / 91.44;
            Console.WriteLine("{0} pul a yd es :   {1} yd\n", pul, result);
        }
        static void Pul_a_Pie(double pul)
        {
            double result = pul * 2.54 * 1 / 30.48;
            Console.WriteLine("{0} pul a pie es :   {1} pie\n", pul, result);
        }
        static void Kg_a_Gr(double kg)
        {
            double result = kg * 1000;
            Console.WriteLine("{0} kg a gr es :   {1} gr\n", kg, result);
        }
        static void Kg_a_Mg(double kg)
        {
            double result = kg * 1000000;
            Console.WriteLine("{0} kg a mlg es :   {1} mlg\n", kg, result);
        }
        static void Kg_a_Lb(double kg)
        {
            double result = kg * 2.205;
            Console.WriteLine("{0} kg a lb es :   {1} lb\n", kg, result);
        }
        static void Kg_a_Tn(double kg)
        {
            double result = kg / 1000;
            Console.WriteLine("{0} kg a tn es :   {1} tn\n", kg, result);
        }
        static void Gr_a_Kg(double gr)
        {
            double result = gr / 1000;
            Console.WriteLine("{0} gr a kg es :   {1} kg\n", gr, result);
        }
        static void Gr_a_Mg(double gr)
        {
            double result = gr * 1000;
            Console.WriteLine("{0} gr a mg es :   {1} mg\n", gr, result);
        }
        static void Gr_a_Lb(double gr)
        {
            double result = gr / 1000 * 2.205;
            Console.WriteLine("{0} gr a lb es :   {1} lb\n", gr, result);
        }
        static void Gr_a_Tn(double gr)
        {
            double result = gr / 1000 * 1 / 1000;
            Console.WriteLine("{0} gr a tn es :   {1} tn\n", gr, result);
        }
        static void Mg_a_Kg(double mg)
        {
            double result = mg / 1000 * 1 / 1000;
            Console.WriteLine("{0} mg a kg es :   {1} kg\n", mg, result);
        }
        static void Mg_a_Gr(double mg)
        {
            double result = mg / 1000;
            Console.WriteLine("{0} mg a gr es :   {1} gr\n", mg, result);
        }
        static void Mg_a_Lb(double mg)
        {
            double result = mg / 1000 * 1 / 1000 * 2.205;
            Console.WriteLine("{0} mg a lb es :   {1} lb\n", mg, result);
        }
        static void Mg_a_Tn(double mg)
        {
            double result = mg / 1000 * 1 / 1000 * 1 / 1000;
            Console.WriteLine("{0} mg a tn es :   {1} tn\n", mg, result);
        }
        static void Lb_a_Kg(double lb)
        {
            double result = lb / 2.205;
            Console.WriteLine("{0} lb a kg es :   {1} kg\n", lb, result);
        }
        static void Lb_a_Gr(double lb)
        {
            double result = lb / 2.205 * 1000;
            Console.WriteLine("{0} lb a gr es :   {1} gr\n", lb, result);
        }
        static void Lb_a_Mg(double lb)
        {
            double result = lb * 1000000 / 2.205;
            Console.WriteLine("{0} lb a mg es :   {1} mg\n", lb, result);
        }
        static void Lb_a_Tn(double lb)
        {
            double result = lb / 2.205 * 1 / 1000;
            Console.WriteLine("{0} lb a tn es :   {1} tn\n", lb, result);
        }
        static void Tn_a_Kg(double tn)
        {
            double result = tn * 1000;
            Console.WriteLine("{0} tn a kg es :   {1} kg\n", tn, result);
        }
        static void Tn_a_Gr(double tn)
        {
            double result = tn * 1000 * 1000;
            Console.WriteLine("{0} tn a gr es :   {1} gr\n", tn, result);
        }
        static void Tn_a_Mg(double tn)
        {
            double result = tn * 1000 * 1000 * 1000;
            Console.WriteLine("{0} tn a mg es :   {1} mg\n", tn, result);
        }
        static void Tn_a_Lb(double tn)
        {
            double result = tn * 1000 * 2.205;
            Console.WriteLine("{0} tn a lb es :   {1} lb\n", tn, result);
        }
        static void Lt_a_Ml(double lt)
        {
            double result = lt * 1000;
            Console.WriteLine("{0} lt a ml es :   {1} ml\n", lt, result);
        }
        static void Lt_a_Gl(double lt)
        {
            double result = lt / 3.78541;
            Console.WriteLine("{0} lt a gl es :   {1} gl\n", lt, result);
        }
        static void Lt_a_Mtcu(double lt)
        {
            double result = lt / 1000;
            Console.WriteLine("{0} lt a mtcu es :   {1} mtcu\n", lt, result);
        }
        static void Lt_a_Cmcu(double lt)
        {
            double result = lt * 1000;
            Console.WriteLine("{0} lt a cmcu es :   {1} cmcu\n", lt, result);
        }
        static void Ml_a_Lt(double ml)
        {
            double result = ml / 1000;
            Console.WriteLine("{0} ml a lt es :   {1} lt\n", ml, result);
        }
        static void Ml_a_Gl(double ml)
        {
            double result = ml / 1000 * 1 / 3.78541;
            Console.WriteLine("{0} ml a gl es :   {1} gl\n", ml, result);
        }
        static void Ml_a_Mtcu(double ml)
        {
            double result = ml / 1000 * 1 / 1000;
            Console.WriteLine("{0} ml a mtcu es :   {1} mtcu\n", ml, result);
        }
        static void Ml_a_Cmcu(double ml)
        {
            double result = ml * 1;
            Console.WriteLine("{0} ml a cmcu es :   {1} cmcu\n", ml, result);
        }
        static void Gl_a_Lt(double gl)
        {
            double result = gl * 3.78541;
            Console.WriteLine("{0} gl a lt es :   {1} lt\n", gl, result);
        }
        static void Gl_a_Ml(double gl)
        {
            double result = gl * 3.78541 * 1000;
            Console.WriteLine("{0} gl a ml es :   {1} ml\n", gl, result);
        }
        static void Gl_a_Mtcu(double gl)
        {
            double result = gl * 3.78541 * 1 / 1000;
            Console.WriteLine("{0} gl a mtcu es :   {1} mtcu\n", gl, result);
        }
        static void Gl_a_Cmcu(double gl)
        {
            double result = gl * 3.78541 * 1 / 1;
            Console.WriteLine("{0} gl a cmcu es :   {1} cmcu\n", gl, result);
        }
        static void Mtcu_a_Lt(double mc)
        {
            double result = mc * 1000;
            Console.WriteLine("{0} mc a lt es :   {1} lt\n", mc, result);
        }
        static void Mtcu_a_Ml(double mc)
        {
            double result = mc * 1000 * 1000;
            Console.WriteLine("{0} mc a ml es :   {1} ml\n", mc, result);
        }
        static void Mtcu_a_Gl(double mc)
        {
            double result = mc * 1000 * 1 / 3.78541;
            Console.WriteLine("{0} mc a gl es :   {1} gl\n", mc, result);
        }
        static void Mtcu_a_Cmc(double mc)
        {
            double result = mc * 1000 * 1000;
            Console.WriteLine("{0} mc a cmc es :   {1} cmc\n", mc, result);
        }
        static void Cmc_a_Lt(double cmc)
        {
            double result = cmc / 1000;
            Console.WriteLine("{0} cmc a lt es :   {1} lt\n", cmc, result);
        }
        static void Cmc_a_Ml(double cmc)
        {
            double result = cmc / 1000 * 1000 / 1;
            Console.WriteLine("{0} cmc a ml es :   {1} ml\n", cmc, result);
        }
        static void Cmc_a_Gl(double cmc)
        {
            double result = cmc / 1000 * 1 / 3.78541;
            Console.WriteLine("{0} cmc a gl es :   {1} gl\n", cmc, result);
        }
        static void Cmc_a_mcu(double cmc)
        {
            double result = cmc / 1000 * 1 / 1000;
            Console.WriteLine("{0} cmc a mcu es :   {1} mcu\n", cmc, result);
        }
    }
}
