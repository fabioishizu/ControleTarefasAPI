using CryptSharp;

namespace ControleProjetosAPI.Utils.CryptoSharp;

public static class CryptoSharp
{
    public static string Codifica(string senha)
    {
        return Crypter.MD5.Crypt(senha);
    }

    public static bool Compara(string senha, string hash)
    {
        return Crypter.CheckPassword(senha, hash);
    }
}
