namespace TP03_Waserman.Gorojod.Models;

public class SugeridorReceta{
    public string nombre {get; set;}
    public DateTime fechaNacimiento {get; set;}
    public string tipoComida {get; set;}
    public int presupuesto {get; set;}
    public int cantidad {get; set;}

    public SugeridorReceta (){

    }
    public string determinarPlato() {
        string plato = " ";
        if (tipoComida == "Caliente" && presupuesto < 3000) 
            plato = "Fideos con manteca";
        else if (tipoComida == "Fría" && presupuesto < 3000)
            plato = "Ensalada";
        else if (tipoComida == "Caliente" && presupuesto >= 3000 && presupuesto <= 7000)
            plato = "Arroz con verduras salteadas";
        else if (tipoComida == "Fría" && presupuesto >= 3000 && presupuesto <= 7000)
            plato = "Ensalada completa con proteínas";
        else if (tipoComida == "Caliente" && presupuesto > 7000)
            plato = "Pollo al horno con guarnición";
        else if (tipoComida == "Fría" && presupuesto > 7000)
            plato = "Tabla de fiambres y quesos";
        return plato;
    }
    public int calcularTiempo() {
        int minutos = 0;
        minutos = cantidad * 20;
        return minutos;
    }
    public string determinarDificultad() {
        string dificultad = " ";
        if (presupuesto < 3000 && cantidad >= 1 && cantidad <= 3)
            dificultad = "Principiante";
        if (presupuesto < 3000 && cantidad >= 4 && cantidad <= 7)
            dificultad = "Intermedio";
        if (presupuesto >= 3000 && presupuesto <= 7000 && cantidad >= 1 && cantidad <= 3)
            dificultad = "Intermedio";
        if (presupuesto >= 3000 && presupuesto <= 7000 && cantidad >= 4)
            dificultad = "Intermedio";
        if (presupuesto > 7000 && cantidad >= 1 && cantidad <= 7)
            dificultad = "Intermedio";
        if (presupuesto > 7000 && cantidad >= 8)
            dificultad = "Avanzado";
        return dificultad;
    }
    public string generarSaludo() {
        string saludo = " ";
        if (DateTime.Now.Hour >= 5 && DateTime.Now.Hour <= 12) 
            saludo = "Buenos días!";
        if (DateTime.Now.Hour >= 13 && DateTime.Now.Hour <= 19) 
            saludo = "Buenas tardes!";
        if (DateTime.Now.Hour >= 20 && DateTime.Now.Hour <= 6)
            saludo = "Buenas noches!";
        return saludo;
    }
    public int calcularEdad(){
        int edad = DateTime.Today.Year - fechaNacimiento.Year;
        if(fechaNacimiento.Month > DateTime.Today.Month){
            edad -= 1;
        }
        else if(fechaNacimiento.Month == DateTime.Today.Month && fechaNacimiento.Day > DateTime.Today.Day){
            edad -=1;
        }
        return edad;
    }
    public string generarTip(int edad) {
        string mensaje = " ";
        if (edad <= 17 && tipoComida == "Caliente") {
            mensaje = "Cuidado que el fuego quema!";
        }
        else if (edad <= 17 && tipoComida == "Fría") {
            mensaje = "No te pases con la sal.";
        }
        else if (edad >= 18 && edad <= 59) {
            mensaje = "Dale que el chori no puede esperar!!";
        }
        else if (edad >= 60 && tipoComida == "Caliente"){
            mensaje = "Si calentas el horno desde antes queda mejor :D";
        }
        else 
            mensaje = "No cortes muy finito!";
        return mensaje;
    }

}
