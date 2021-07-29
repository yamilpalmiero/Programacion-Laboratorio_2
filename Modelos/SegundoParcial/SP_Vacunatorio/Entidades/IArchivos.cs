namespace Entidades
{
    public interface IArchivos<T>
    {
        bool Guardar(string archivo, T dato);

        bool Leer(string archivo, out T dato);
    }
}
