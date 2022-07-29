package antsoft.client;

/**
 * Created by ANT on 11/14/2015.
 */
public class randomtransfer_class {
    private static Integer nomor_Renamed;
    private static Integer layanan_Renamed;
    public randomtransfer_class(Integer nomor, Integer layanan)
    {
        nomor_Renamed = nomor;
        layanan_Renamed = layanan;
    }

    public randomtransfer_class()
    {

    }

    public final Integer getNomor()
    {
        return nomor_Renamed;
    }
    public final Integer getService()
    {
        return layanan_Renamed;
    }


}
