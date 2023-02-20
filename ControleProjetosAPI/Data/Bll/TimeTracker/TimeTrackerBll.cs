namespace ControleProjetosAPI.Data.Bll.TimeTracker;

public class TimeTrackerBll
{
    public static bool validaDateTime(DateTime inicio, DateTime fim)
    {
        return inicio <= fim ? true : false;
    }
}
