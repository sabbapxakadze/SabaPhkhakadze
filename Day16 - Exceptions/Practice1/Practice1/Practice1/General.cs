using System.Text;
public class General
{
    public string GetLastInnerExceptionMessage(Exception ex)
    {
        if (ex == null) return null;
        while (ex.InnerException != null)
        {
            ex = ex.InnerException;
        }
        return ex.Message ?? "No message here!";
    }
    public string GetAllInnerExceptionMessage(Exception ex)
    {
        if (ex == null) return string.Empty;
        StringBuilder str = new StringBuilder();
        while (ex.InnerException != null)
        {
            str.Append(ex.Message + " --> ");
            ex = ex.InnerException;
        }
        str.Append(ex.Message);
        return str.ToString();
    }
}