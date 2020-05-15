using NUnit.Framework;
using Patrones.Entities;
using Patrones.AbstractFactory;
using Patrones.FactoryMethod;
using Patrones.Entities.Sandwish;
using Patrones.Singleton;
using Patrones.Adapter;
using Patrones.Bridge;
using Patrones.Facade;
using Patrones.Proxy;
using Patrones.Composite;
using Patrones.Decorator;
using Patrones.FlyWeight;
using Patrones.Builder;

namespace TestGof
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AbstractFactoryLaberinto()
        {
            FabricaDeLaberintosEncantados fabricaDeLaberintosEncantados = new FabricaDeLaberintosEncantados();
            JuegoDelLaberinto juego = new JuegoDelLaberinto();

            Laberinto laberinto = juego.CrearLaberinto(fabricaDeLaberintosEncantados);

            string mensaje = laberinto.Habitaciones[0].Entrar();

            Assert.AreEqual(" Habitacion Encantada :1", mensaje);
        }


        [Test]
        public void BuilderLaberinto()
        {
            Laberinto laberinto;
            JuegoDelLaberinto juegoDelLaberinto = new JuegoDelLaberinto();
            ConstructorLaberintoenEle constructor = new ConstructorLaberintoenEle();

            laberinto = juegoDelLaberinto.CrearLaberinto(constructor);

            Assert.AreEqual("Laberinto en Ele", constructor.ObtenerNombre());

            
        }


        [Test]
        public void FactoryMethodPuertaEncantada()
        {
            Habitacion h1 = new Habitacion(0);
            Habitacion h2 = new Habitacion(1);

            FactoryConcretoPuertaEncantada factoryConcretoPuertaEncantada = new FactoryConcretoPuertaEncantada();

            Puerta puerta = factoryConcretoPuertaEncantada.FactoryMethod(h1, h2);

            string mensaje = puerta.Entrar();

            Assert.AreEqual("Pasando Por Puerta Encantada Habitacion :1", mensaje);

        }

        [Test]
        public void FactoryMethodPuertaDañada()
        {
            Habitacion h1 = new Habitacion(0);
            Habitacion h2 = new Habitacion(1);

            FactoryConcretoPuertaDañada puertaDañada = new FactoryConcretoPuertaDañada();

            Puerta puerta = puertaDañada.FactoryMethod(h1, h2);

            string mensaje = puerta.Entrar();

            Assert.AreEqual("Pasando Por Puerta Dañada Habitacion :1", mensaje);

        }

        [Test]
        public void PrototypeSanduche ()
        {
            SanducheMenu sanducheMenu = new SanducheMenu();

            sanducheMenu["BLT"] = new Sanduche("Integral", "Tocino", "", "Lechuga, Tomate");
            Sanduche sanduche = sanducheMenu["BLT"].Clone() as Sanduche;
 
            Assert.AreEqual("Integral ,Tocino , ,Lechuga, Tomate", sanduche.getIngredientes());

        }

        [Test]
        public void SingletonCocina()
        {
            Cocina cocina = Cocina.Instance;
            Cocina cocina2 = Cocina.Instance;

            Assert.AreEqual(cocina, cocina2);

        }

        [Test]
        public void AdapterMotorElectrico()
        {
            MotorElectricoAdapter motorElectricoAdapter = new MotorElectricoAdapter();

            string mensaje = motorElectricoAdapter.Encender();

            Assert.AreEqual("Encendiendo Motor Electrico", mensaje);
        }

        [Test]
        public void BridgeEnvio()
        {
            EnviarColombia enviarColombia = new EnviarColombia();
            EnviarPortugal enviarPortugal = new EnviarPortugal();

            RepartoAmazon reparto = new RepartoAmazon("1", enviarColombia);

            reparto.asignarEnvio(enviarPortugal);

            Assert.AreEqual("Pedido entregado a Portugal", reparto.obtenerEnvio().entregar());
        }

        [Test]
        public void FacadeEmpresa()
        {
            Comprador cliente = new Comprador();

            Empresa empresa = new Empresa();

            string mensaje = empresa.escucharQuejas(cliente);

            Assert.AreEqual("Escuchando queja de comprador", mensaje);
        }


        [Test]
        public void ProxyServidor()
        {
            Servidor servidor = new ProxyMiServidor(20, "host");
            string mensaje = servidor.descargar("descargaPermitida");

            Assert.AreEqual("Descargando de :host", mensaje);

        }


        [Test]
        public void CompositeArchivo()
        {
            Directorio directorio = new Directorio("Raiz");

            Archivo archivo = new Archivo("archivo1.txt", 180);
            Archivo archivo2 = new Archivo("Pelicula.mp4", 87);
            Archivo archivo3 = new Archivo("cancion.mp3", 46);

            Directorio directorio1 = new Directorio("Fotos");

            Archivo archivo4 = new Archivo("imagen.png", 4);

            directorio1.AgregarHijo(archivo4);


            Directorio directorio2 = new Directorio("Descargas");

            directorio.AgregarHijo(archivo);
            directorio.AgregarHijo(archivo2);
            directorio.AgregarHijo(archivo3);

            directorio.AgregarHijo(directorio1);
            directorio.AgregarHijo(directorio2);

            Assert.AreEqual(317, directorio.ObtenerTamaño);
        }

        [Test]
        public void DecoratorCuentaBancaria()
        {
            Cuenta c = new Cuenta(1, "Rafa");

            ICuentaBancaria cuentaAhorro = new CuentaAhorro();
            ICuentaBancaria cuentaBlindada = new BlindajeDecorador(cuentaAhorro);

            Assert.AreEqual("Se creo Cuenta de AhorroSe Agrego Blindaje a su cuenta", cuentaBlindada.abrirCuenta(c));
            

        }


        [Test]
        public void SliderFlyWeight()
        {
            SliderFactory factory = new SliderFactory();

            Slider character = factory.GetSlider('B');
            
            string mensaje = character.Display(1);

            Assert.AreEqual("Slider #1: Bacon Master - topped with American cheese and lots of bacon! $" + 2.39m, mensaje);


        }







    }
}