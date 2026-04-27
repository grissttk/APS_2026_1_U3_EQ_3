using Clase_ICDIA_Unidad3.Utilidades;

namespace Clase_ICDIA_Unidad3.Runners;

public class RunnerLeerArchivos
{
    public RunnerLeerArchivos()
    {

        LeerArchivos.Leer();

        LeerArchivos archivo;
        archivo = new LeerArchivos();
        //archivo.Leer();
        archivo.LeerV2();
    }
}