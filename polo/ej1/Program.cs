using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace tp03
{

    class Persona
    {
        public string nombre;
        public string apellido;
        public string pais;

        public Persona()
        {

        }


        public Persona(string nombre, string apellido, string pais)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.pais = pais;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = { "Aarón", "Antonio", "Manuel", "José", "Francisco", "David", "Juan", "José Antonio", "Javier", "Daniel", "José Luis", "Francisco Javier", "Carlos", "Jesús", "Alejandro", "Miguel", "José Manuel", "Rafael", "Miguel Ángel", "Pedro", "Pablo", "Ángel", "Sérgio", "José Maria", "Fernando", "Jorge", "Luís", "Alberto", "Juan Carlos", "Álvaro", "Adrián", "Juan José", "Diego", "Raúl", "Iván", "Juan Antonio", "Rubén", "Enrique", "Oscar", "Ramón", "Vicente", "Andrés", "Juan Manuel", "Joaquín", "Santiago", "Víctor", "Eduardo", "Mario", "Roberto", "Jaime", "Francisco José", "Marcos", "Ignacio", "Alfonso", "Jordi", "Hugo", "Ricardo", "Salvador", "Guillermo", "Emilio", "Gabriel", "Marc", "Gonzalo", "Julio", "Julian", "Mohamed", "Jose Miguel", "Tomas", "Martin", "Agustin", "Jose Ramon", "Nicolás", "Ismael", "Joan", "Félix", "Samuel", "Cristian", "Aitor", "Lucas", "Héctor", "Juan Francisco", "Iker", "Josep", "José Carlos", "Alex", "Mariano", "Domingo", "Sebastián", "Alfredo", "Cesar", "José Ángel", "Felipe", "José Ignacio", "Víctor Manuel", "Rodrigo", "Luis Miguel", "Mateo", "José Francisco", "Juan Luis", "Xavier", "Albert", "Gregorio", "Pau", "Lorenzo", "Antonio José", "Esteban", "Borja", "Cristóbal", "Aarón", "Arturo", "Eric", "José Javier", "Izan", "Eugénio", "Isaac", "Juan Miguel", "António Jesus", "Mohammed", "Joel", "Jesus Maria", "Francisco Manuel", "Asier", "Jaume", "German", "Abel", "Jonathan", "Darío", "Pedro José", "Valentin", "José Vicente", "Unai", "Mikel", "Bruno", "Moises", "Sergi", "Ahmed", "Christian", "Juan Ramón", "Marco", "Adolfo", "Juan Pedro", "Íñigo", "Manuel Jesus", "Gerard", "Jon", "Pol", "Omar", "Ernesto", "Isidro", "Arnau", "Miquel", "Benito", "Israel", "Oriol", "Leo", "António Manuel", "Bernardo", "Gerardo", "Eloy", "Jónatan", "Carmelo", "Federico", "Adam", "Francesc", "Pascual", "José Alberto", "Jesus Manuel", "Luís Alberto", "Juan Jesus", "Adria", "Roger", "Alonso", "Josep Maria", "Bartolomé", "Iñaki", "Kevin", "Elías", "Oliver", "Benjamín", "Saúl", "Carles", "Matías", "Marcelino", "Pere", "Juan Pablo", "Fermín", "Martí", "Pedro Antonio", "Lluís", "Guillem", "Antoni", "Ander", "Marco Antonio", "Youssef", "José Enrique", "Erik", "Alexander", "Carlos Alberto", "Ángel Luis", "Aurelio", "Juan Ignacio", "Abraham", "Francisco Jesús", "Xabier", "Said", "Aleix", "Gorka", "Jerónimo", "Julen", "Jacinto", "Román", "Ferrán", "Eusebio", "Gustavo", "José Juan", "Luis Fernando", "Manuel Ángel", "Victoriano", "Damián", "Luis Manuel", "Leonardo", "Carlos Javier", "Yeray", "Rachid", "Isidoro", "Enric", "Pedro Luis", "Enzo", "Jan", "Juan Bautista", "Armando", "José David", "Blas", "Teodoro", "Dionísio", "Santos", "Ginés", "Cándido", "Justo", "José Joaquín", "Eduard", "Florencio", "Ali", "Juan María", "Eneko", "Jairo", "Francisco Antonio", "Edgar", "Emiliano", "Ian", "Julio Cesar", "Mustapha", "Emilio José", "Serafín", "José Andrés", "Luis Antonio", "Máximo", "Biel", "Jesús Ángel", "Faustino", "Simón", "Luis Ángel", "Luis María", "Nil", "Fidel", "Igor", "Ramiro", "Jacobo", "Alexis", "Claudio", "Amador", "Ezequiel", "Alexandre", "Manuel Antonio", "Francisco Miguel", "Rogelio", "Pedro Manuel", "Andreu", "Hassan", "Yago", "Ion", "Luciano", "José Fernando", "Juan Diego", "Luca", "Juan Dios", "José Daniel", "Joaquim", "Ildefonso", "Juan Vicente", "Modesto", "Jorge Luís", "Carlos Manuel", "Ibai", "Manuel José", "Dylan", "Juan Andrés", "Florentino", "Antonio Javier", "Mauro", "Leandro", "António Miguel", "Cayetano", "Muhammad", "Gael", "Antonio Luis", "Luis Javier", "Iago", "Aritz", "Josué", "Paulino", "Luís Carlos", "Aimar", "Constantino", "Pedro Jesus", "Pedro Maria", "Rayan", "Eládio", "Fabián", "Avelino", "Khalid", "Celestino", "Nestor", "Manel", "Saturnino", "Francesc Xavier", "Juan Ángel", "Ángel Manuel", "Robert", "Vasile", "Gheorghe", "Hamza", "Rufino", "Abdellah", "Ayoub", "Imanol", "Markel", "Alan", "Bilal", "Gaspar", "Marcelo", "Oier", "Ricard", "Thiago", "Fábio", "Hicham", "Andoni", "Abdelkader", "Brais", "Clemente", "Basílio", "Josu", "Raimundo", "Juan Alberto", "Bernat", "Fernando José", "Ioan", "Jesús Antonio", "Feliciano", "Luis Enrique", "Hilario", "Brahim", "Ángel Maria", "Roberto Carlos", "Didac", "Joseba", "Evaristo", "Marcel", "Marcial", "Noel", "Eliseo", "Laureano", "Pedro Pablo", "Ibrahim", "Abdelaziz", "Patrício", "Narciso", "Antón", "António Francisco", "Benigno", "Anas", "Francisco Luís", "Bernardino", "Cecílio", "Maurício", "Adan", "Segundo", "Constantín", "Juan David", "Leopoldo", "Pedro Javier", "Camilo", "Abderrahim", "Brian", "Manuel Alejandro", "Yassine", "Karim", "Michael", "Marian", "Valeriano", "Alain", "Carlos José", "Demétrio", "Hamid", "Roque", "Cesáreo", "Pelayo", "Pedro Miguel", "Francisco Borja", "José Gabriel", "Octávio", "Rodolfo", "Axel", "Max", "José Félix", "Francisco Asis", "Jesus Miguel", "José Pedro", "Cipriano", "Florín", "Anastasio", "Bernabé", "Bienvenido", "José Rafael", "Lucío", "Lazaro", "Nicolae", "Luís Francisco", "Denis", "Elói", "Manuel Francisco", "Baltasar", "Anselmo", "Paul", "Abdeslam", "Amadeo", "Lluc", "Ignasi", "Mamadou", "Jamal", "Alberto José", "Juan Enrique", "Beñat", "Placido", "Ismail", "Driss", "Eulógio", "José Domingo", "Jesus Javier", "José Alejandro", "Celso", "Fulgencio", "Zakaria", "Teófilo", "Casimiro", "Pablo José", "Noah", "Jorge Juan", "Aziz", "Aníbal", "Victor José", "Carlos Enrique", "Vicent", "Baldomero", "Samir", "Herminio", "Juan Gabriel", "Vicente José", "Alessandro", "Orlando", "Luís Alfonso", "Maximino", "Ibón", "Noé", "Juan Fernando", "Alexandru", "Gustavo Adolfo", "Marcos Antonio", "Moussa", "Iban", "José Pablo", "Teo", "Norberto", "Ayman", "Nabil", "Unax", "Aquilino", "Alejandro José", "Yassin", "Eduardo José", "José Tomas", "Vidal", "Gaizka", "Marino", "António Maria", "Adil", "Carlos Antonio", "Luis Eduardo", "Kilian", "Gumersindo", "José Jesús" };
            string[] apellidos = { "Polo", "García", "Rodríguez", "González", "Fernández", "López", "Martínez", "Sánchez", "Pérez", "Gómez", "Martin", "Jiménez", "Ruiz", "Hernández", "Díaz", "Moreno", "Muñoz", "Álvarez", "Romero", "Alonso", "Gutiérrez", "Navarro", "Torres", "Domínguez", "Vázquez", "Ramos", "Gil", "Ramírez", "Serrano", "Blanco", "Molina", "Morales", "Suarez", "Ortega", "Delgado", "Castro", "Ortiz", "Marín", "Rubio", "Sanz", "Núñez", "Medina", "Iglesias", "Cortes", "Castillo", "Garrido", "Santos", "Lozano", "Guerrero", "Cano", "Prieto", "Méndez", "Cruz", "Flores", "Herrera", "Gallego", "Márquez", "León", "Peña", "Calvo", "Cabrera", "Vidal", "Campos", "Vega", "Fuentes", "Carrasco", "Reyes", "Diez", "Caballero", "Nieto", "Aguilar", "Santana", "Pascual", "Herrero", "Montero", "Hidalgo", "Giménez", "Lorenzo", "Ibáñez", "Vargas", "Santiago", "Duran", "Ferrer", "Benítez", "Mora", "Arias", "Vicente", "Carmona", "Crespo", "Román", "Soto", "Pastor", "Velasco", "Sáez", "Rojas", "Moya", "Parra", "Soler", "Bravo", "Gallardo", "Esteban", "Pardo", "Rivera", "Franco", "Merino", "Rivas", "Lara", "Silva", "Espinosa", "Izquierdo", "Camacho", "Vera", "Arroyo", "Casado", "Ríos", "Redondo", "Mendoza", "Luque", "Galán", "Rey", "Sierra", "Montes", "Otero", "Segura", "Carrillo", "Marcos", "Soriano", "Bernal", "Martí", "Heredia", "Robles", "Valero", "Vila", "Palacios", "Macías", "Expósito", "Contreras", "Guerra", "Varela", "Benito", "Roldan", "Pereira", "Mateo", "Bueno", "Andrés", "Miranda", "Villar", "Guillen", "Aguilera", "Mateos", "Escudero", "Casas", "Rivero", "Padilla", "Aparicio", "Calderón", "Acosta", "Estévez", "Beltrán", "Salazar", "Gálvez", "Menéndez", "Salas", "Rico", "Guzmán", "Jurado", "Conde", "Bermúdez", "Gracia", "Quintana", "Abad", "Aranda", "Plaza", "Blázquez", "Santamaría", "Ávila", "Roca", "Manzano", "Trujillo", "Costa", "Hurtado", "Villanueva", "Pacheco", "Miguel", "Serra", "Rueda", "Cuesta", "Escobar", "Tomas", "Mesa", "de la Fuente", "Simón", "Del Rio", "Luna", "Lázaro", "Pons", "Alarcón", "Sancho", "Millán", "Zamora", "Castaño", "Maldonado", "Chen", "Blasco", "Paredes", "Salvador", "Bermejo", "Bautista", "Ballesteros", "Valverde", "Montoya", "de la Cruz", "Ponce", "Antón", "Oliva", "Valle", "Cordero", "Murillo", "Lorente", "Cuevas", "Rodrigo", "Pozo", "Collado", "Juan", "Mas", "Cuenca", "Martos", "Ordoñez", "Barrera", "Amador", "Barroso", "Quesada", "de la Torre", "Marco", "Ros", "Pulido", "Valencia", "Navas", "Alba", "Cabello", "Arenas", "Corral", "Gimeno", "Rojo", "Galindo", "Soria", "Mena", "Aguado", "Vallejo", "Escribano", "Puig", "Saiz", "Caro", "Domingo", "Asensio", "Lucas", "Aguirre", "Naranjo", "Villalba", "Mata", "Polo", "Paz", "Reina", "Ramón", "Linares", "Moran", "Ojeda", "Leal", "Singh", "Burgos", "Bonilla", "Sosa", "Carretero", "Mohamed", "Oliver", "Cáceres", "Aragón", "Cárdenas", "Córdoba", "Castellano", "Carrión", "Villa", "Chacón", "Correa", "Rosa", "Clemente", "Roig", "Zapata", "Calero", "Saavedra", "Juárez", "Velázquez", "Carrera", "Andreu", "Hernando", "Alcaraz", "Toledo", "Cobo", "Quintero", "Pineda", "Sola", "Villegas", "Salgado", "Ayala", "Riera", "Vela", "Barrios", "Moral", "Llorente", "Domenech", "Carbonell", "Sevilla", "Requena", "Alfonso", "Ferreira", "Cámara", "Prado", "Arribas", "Peláez", "Olivares", "Solis", "Luis", "Carballo", "Salinas", "Piñeiro", "Font", "Pinto", "de la Rosa", "Esteve", "Perea", "Marrero", "Grau", "Castilla", "Cantero", "Cardona", "Rincón", "Bosch", "Marques", "Arévalo", "Cid", "Palma", "Ballester", "Palomo", "Porras", "Sanchis", "Baena", "Casanova", "Pino", "Nicolás", "Belmonte", "Miralles", "Barba", "Lago", "Recio", "Ventura", "Da Silva", "Cobos", "Sala", "Angulo", "Herranz", "Madrid", "Muñiz", "Arranz", "Cabezas", "Vélez", "Cuadrado", "Ochoa", "Wang", "Barreiro", "Coll", "Peralta", "Vaquero", "Cervera", "Becerra", "Navarrete", "Ocaña", "Alfaro", "Bello", "Granados", "Lin", "Castellanos", "Puente", "Tapia", "Vergara", "Alcántara", "Gámez", "Estrada", "Corrales", "Duarte", "Mejías", "Godoy", "Pujol", "Latorre", "Losada", "Valls", "Egea", "Falcón", "Fajardo", "Barragán", "Campo", "Rovira", "Segovia", "Valenzuela", "Huertas", "Sastre", "Ruano", "Carvajal", "Toro", "Catalán", "Pavón", "Cerezo", "Cebrián", "Fraile", "Rosales", "Borrego", "Arjona", "Morcillo", "Barbero", "Ariza", "Del Valle", "Guijarro", "Morillo", "Aznar", "Portillo", "Figueroa", "Peinado", "Zambrano", "Dávila", "Ferreiro", "Romera", "Cánovas", "Amaya", "Melero", "Valdés", "Duque", "Alcaide", "Galván", "Gordillo", "Solé", "Jorge", "Agudo", "Llamas", "Lobato", "Ahmed", "Tirado", "Espejo", "Sainz", "Zhang", "Tejero", "Real", "Dorado", "Criado", "Chamorro", "Royo", "Solano", "Mosquera", "Grande", "Gonzalo", "Frías", "Barrio", "Moyano", "Freire", "Pizarro", "Rosado", "de Miguel", "Olmedo", "Alvarado", "Avilés", "Calleja", "Paniagua", "Alcalá", "Alcázar", "Huerta", "Salguero", "Pla", "Osorio", "Garzón", "Brito", "Araujo", "Sáenz", "Vásquez", "Ferrero", "Salcedo", "Tena", "Del Pozo", "Dos Santos", "Alcalde", "Páez", "Noguera", "Andrade", "Serna", "Borja", "Chaves", "Llorens", "Rebollo", "Pazos", "Arce", "Piñero", "Heras", "Vives", "Lafuente", "Pena", "Poveda", "Bonet", "Hiervas", "Orozco", "Abellán", "Bartolomé", "Quirós", "Barranco", "Olmo", "Matéu", "Haro", "Valiente", "Cabeza", "Valles", "Castañeda", "Palomino", "Garcés", "Chávez", "Laguna", "Borras", "Mira", "Giner", "Mellado", "Llopis", "Souto", "Afonso", "Molero", "Carreño", "Yáñez", "Barceló", "Bilbao", "Palomares", "Osuna", "Li", "Del Castillo", "Ceballos", "Mejía", "Calle", "Fuertes", "Maestre", "Leiva", "Del Pino", "Vílchez", "Bustamante", "Montesinos", "Acevedo", "San José", "Castello", "Ribas", "Zafra", "Olmos", "Urbano", "Bellido", "Prats", "Pareja", "Felipe", "Baeza", "Puertas", "Vizcaíno", "Murcia", "Jaén", "Tejada", "Mínguez", "Perales", "Gascón", "Carreras", "Zaragoza", "Enríquez", "Montoro", "Sebastián", "Luengo", "Campillo", "Valera", "de Castro", "Peris", "Alegre", "de León", "Arcos", "Gago", "Ye", "Baños", "Xu", "Sarmiento", "Cañas", "Ledesma", "Monge", "Báez", "Sandoval", "Casal", "Bustos", "Fuster", "Orellana", "Sobrino", "Rocha", "Vilar", "Nadal", "Tello", "Sanjuán", "Cazorla", "Jerez", "Liu", "Tejedor", "Salmerón", "Seoane", "Jara", "Armas", "Moreira", "Conesa", "Montiel", "Batista", "Arteaga", "Patiño", "Pallares", "Zabala", "Maya", "Ferre", "Lobo", "Barea", "Bejarano", "Verdú", "Padrón", "Barrero", "Mari", "Jordán", "Veiga", "Moro", "Mayor", "Tamayo", "Ripoll", "Alemán", "Morón", "Tortosa", "Ferrando", "Del Campo", "Climent", "Prados", "Machado", "Prada", "Catalá", "Taboada", "San Martin", "Wu", "Ayuso", "Fraga", "Amoros", "Jaramillo", "Almeida", "Abril", "Peñalver", "Canales", "Infante", "Diéguez", "Perdomo", "Kaur", "Manrique", "Galera", "Barros", "Álvaro", "Yuste", "Cerda", "Mota", "Maroto", "Manso", "Giraldo", "Nogales", "Pinilla", "Lucena", "Albert", "Berenguer", "Medrano", "Pedrosa", "Echeverría", "Cifuentes", "Atienza", "Ribera", "Villaverde", "Míguez", "Sampedro", "Zhou", "Villena", "Del Olmo", "Dueñas", "Manzanares", "Miro", "Diego", "Viñas", "Montaño", "Raya", "Úbeda", "Teruel", "Sevillano", "Ortuño", "Almagro", "Alves", "Ali", "Merchán", "Echevarría", "Novoa", "España", "Francisco", "Bolaños", "de Las Heras", "Robledo", "Montilla", "Morillas", "Quevedo", "Ibarra", "Iniesta", "Checa", "Acedo", "Espinoza", "Diallo", "Talavera", "Lujan", "Puerto", "Trigo", "Ares", "de Los Santos", "Caparros", "Granado", "de Diego", "Herreros", "Matas", "Macía", "Téllez", "Francés", "Tovar", "Vivas", "Hermida", "Coronado", "Segarra", "Balaguer", "Meléndez", "Bernabé", "Puerta", "Espada", "Monzón", "Toribio", "Zamorano", "Pina", "Tome", "Peral", "Buendía", "Acuña", "Arana", "Mariño", "Cubero", "Palacio", "Valdivia", "Molinero", "Mayo", "Barbera", "Cervantes", "Encinas", "Narváez", "Prat", "Bernabéu", "Torre", "Lamas", "Rodrígues", "Melian", "Carro", "Cañete", "Lloret", "Badía", "Peiro", "Parrilla", "Saura", "Coca", "Rodenas", "Hinojosa", "Sanmartín", "Sepúlveda", "Costas", "Fariña", "Cuellar", "Martorell", "Mayoral", "Pedraza", "Mariscal", "Carrero", "Boix", "Ureña", "Camps", "Céspedes", "Girón", "Quiles", "Piqueras", "Guevara", "Zurita", "Revuelta", "Fidalgo", "Andújar", "Gamero", "Cañadas", "Mir", "Arellano", "Planas", "Parada", "Goñi", "Picazo", "Centeno", "Sales", "Perera", "Viera", "Lema", "Gordo", "Romo", "Guisado", "Riquelme", "Amor", "Rial", "Torregrosa", "Álamo", "Pico", "Vilches", "Quiroga", "Mera", "Frutos", "Mestre", "Amores", "Carrascosa", "Solana", "Palau", "Sabater", "Benavides", "Codina", "Botella", "Vegas", "Adán", "Seguí", "Gabarri", "Lora", "Calatayud", "Arnau", "de Dios", "Fonseca", "Palazón", "Quero", "Nevado", "Antúnez", "Novo", "Labrador", "Zhu", "Chico", "Parejo", "Nieves", "Hermoso", "Toledano", "Herraiz", "Revilla", "Jaime", "Antolín", "Cantos", "Ribes", "Montenegro", "Neira", "Fuente", "Flórez", "Hoyos", "Pellicer", "Jimeno", "Del Moral", "Ramiro", "Belda", "Silvestre", "Vico", "Caamaño", "Postigo", "Verdugo", "Piña", "Torralba", "Megías", "Zheng", "Sempere", "Farre", "Guirado", "Cordón", "Elvira", "Velásquez", "Matos", "Yagüe", "Mansilla", "Abreu", "Guardiola", "Sacristán", "Alemany", "Galiano", "Canto", "Comas", "Vaca", "Llanos", "Cabanillas", "Rosell", "Oliveira", "Sousa", "Uriarte", "Cornejo", "Berrocal", "Quiñones", "Cañizares", "Colomer", "Aroca", "Arnaiz", "Capdevila", "Carranza", "Feijoo", "Gilabert", "Rus", "Rosello", "Chaparro", "Maza", "Perello", "Espín", "Gisbert", "Trillo", "Sans", "Pórtela", "Mercado", "Figueras", "Cerdán", "Cristóbal", "Oviedo", "Barrientos", "Mañas", "Monteagudo", "Rio", "Torrejón", "Ndiaye", "San Juan", "Amado", "Aliaga", "Tudela", "Olivera", "Carpio", "Garriga", "Betancor", "Campoy", "Muriel", "Amat", "Espino", "Seco", "Lima", "Tejera", "Meseguer", "Holgado", "Saldaña", "Mármol", "Bastida", "Reig", "Morilla", "Julián", "Yang", "Diop", "Plasencia", "Gomes", "Camino", "Gavilán", "San Miguel", "Melgar", "Samper", "Valcárcel", "Valderrama", "Guirao", "Morera", "Chica", "Castells", "Paris", "Ruz", "Ferrera", "Anaya", "Nogueira", "Benavente", "Julia", "Gaspar", "de Haro", "Florido", "Lillo", "Elías", "Ferreras", "Escalante", "Morato", "Casáls", "Cardoso", "Urrutia", "Dorta", "Barbosa", "Gomis", "Daza", "Reche", "Arrieta", "Pereda", "Montalvo", "Calzada", "Casares", "Mérida", "Lorca", "Gallo", "Higueras" };
            string[] paises = { "Argentina", "Brasil", "Paraguay" };
            int randoma;
            int randomp;
            int randome;
            int randompa;
            int randompaa;
            int conta = 0;
            int conta1 = 0;
            int conta2 = 0;


            int cont = 0;
            int cont1 = 0;
            int cont2 = 0;
            DateTime hora = DateTime.Now;
            DateTime horaActual = DateTime.Now;
            TimeSpan tiempoTrasncurrido;
            DateTime hora1 = DateTime.Now;
            DateTime horaActual1 = DateTime.Now;
            TimeSpan tiempoTrasncurrido1;
            DateTime hora2 = DateTime.Now;
            DateTime horaActual2 = DateTime.Now;
            TimeSpan tiempoTrasncurrido2;
            DateTime hora3 = DateTime.Now;
            DateTime horaActual3 = DateTime.Now;
            TimeSpan tiempoTrasncurrido3;
            List<Persona> personas = new List<Persona>();
            List<string> nacion = new List<string>();
            Console.CursorVisible = false;
            while (true)
            {
                horaActual = DateTime.Now;
                tiempoTrasncurrido = horaActual - hora;
                horaActual1 = DateTime.Now;
                tiempoTrasncurrido1 = horaActual1 - hora1;
                horaActual2 = DateTime.Now;
                tiempoTrasncurrido2 = horaActual2 - hora2;
                horaActual3 = DateTime.Now;
                tiempoTrasncurrido3 = horaActual3 - hora3;

                if (tiempoTrasncurrido1.Seconds == 2)
                {
                    randoma = new Random().Next(0, 500);
                    randomp = new Random().Next(0, 1000);
                    randompa = new Random().Next(0, 3);
                    if (paises[randompa] == "Argentina")
                    {

                        conta++;
                    }
                    if (paises[randompa] == "Paraguay")
                    {

                        conta1++;
                    }
                    if (paises[randompa] == "Brasil")
                    {

                        conta2++;
                    }
                    personas.Add(new Persona(nombres[randoma], apellidos[randomp], paises[randompa]));
                    hora1 = DateTime.Now;





                }
                if (tiempoTrasncurrido.Seconds == 15)
                {
                    randome = new Random().Next(0, personas.Count);
                    personas.RemoveAt(randome);
                    hora = DateTime.Now;
                    randome =0;
                    if (paises[randome] == "Argentina")
                    {

                        conta--;
                    }
                    if (paises[randome] == "Paraguay")
                    {

                        conta1--;
                    }
                    if (paises[randome] == "Brasil")
                    {

                        conta2--;
                    }

                }
                if (tiempoTrasncurrido3.Seconds == 300)
                {
                    randompaa = new Random().Next(0, 3);


                    for (int i = personas.Count - 1; i >= 0; i--)
                    {

                        if (personas[i].pais == paises[randompaa])
                        {

                            personas.RemoveAt(i);
                        }


                    }
                    if (paises[randompaa] == "Argentina")
                    {

                        conta = 0;
                    }
                    if (paises[randompaa] == "Paraguay")
                    {

                        conta1 = 0;
                    }
                    if (paises[randompaa] == "Brasil")
                    {

                        conta2 = 0;
                    }
                    hora3 = DateTime.Now;

                }
                if (tiempoTrasncurrido2.Seconds == 2)
                {

                    Console.Clear();
                    Console.SetCursorPosition(10, 0);
                    Console.WriteLine("Hay " + conta + " en Argentina");

                    Console.SetCursorPosition(50, 0);
                    Console.WriteLine("Hay " + conta2 + " en Brasil");

                    Console.SetCursorPosition(80, 0);
                    Console.WriteLine("Hay " + conta1 + " en Paraguay");





                    foreach (var persona in personas)
                    {

                        if (persona.pais == "Argentina")
                        {

                            Console.SetCursorPosition(10, cont + 1);
                            Console.WriteLine(persona.apellido + " " + persona.nombre);
                            cont++;
                        }
                        if (persona.pais == "Brasil")
                        {

                            Console.SetCursorPosition(50, cont2 + 1);
                            Console.WriteLine(persona.apellido + " " + persona.nombre);
                            cont2++;
                        }
                        if (persona.pais == "Paraguay")
                        {

                            Console.SetCursorPosition(80, cont1 + 1);
                            Console.WriteLine(persona.apellido + " " + persona.nombre);
                            cont1++;
                        }
                    }
                    cont = 0;
                    cont1 = 0;
                    cont2 = 0;
                    hora2 = DateTime.Now;
                }

            }
        }
    }
}
