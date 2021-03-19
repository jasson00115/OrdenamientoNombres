


public class Estudiante : Comparador {

    public int numMat;
    public string nombre;

    public bool igualQue(object q)
    {
        throw new System.NotImplementedException();
    }

    public bool mayorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;

        return nombre.CompareTo(p2.nombre) >= 0;
    }

    public bool mayorQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        //Usamos compareTo >0 va a ser la letra que este mas cercana a la z 
        return nombre.CompareTo(p2.nombre) > 0;
    }

    public bool menorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) <= 0;
    }

    public bool menorQue(object op2) {
        Estudiante p2 = (Estudiante)op2;
        //Usamos compareTo <0 va a ser la letra que este mas cercana a la a 
        return nombre.CompareTo(p2.nombre) < 0;
    }

}
