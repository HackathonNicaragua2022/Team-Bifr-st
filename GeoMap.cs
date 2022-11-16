using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeoMap : MonoBehaviour
{
    private string urlMap="";

    public RawImage imageMap;
    public Text latitudText;
    public Text longitudText;
    public int zoom = 20;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Get Map");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Metodo para acercar el mapa desde un boton
    public void ZoomInButton()
    {
        zoom++;
        StartCoroutine("GetMap");
    }

    //Metodo para alejar el mapa desde un boton
    public void ZoomOutButton()
    {
        if(zoom >=0 ) zoom--;
        StartCoroutine("GetMap");

    }

    [System.Obsolete]
    private IEnumerator GetMap()
    {
        Input.location.Start();

        float latitud = Input.location.lastData.latitude;
        yield return latitud;

        float longitud = Input.location.lastData.longitude;
        yield return longitud;

        //Codigo del Mapa de Google Maps
        
       urlMap = "https://maps.googleapis.com/maps/api/staticmap?center=Brooklyn+Bridge,New+York,NY&zoom=13&size=600x300&maptype=roadmap&markers=color:blue%7Clabel:S%7C40.702147,-74.015794&markers=color:green%7Clabel:G%7C40.711614,-74.012318&markers=color:red%7Clabel:C%7C40.718217,-73.998284&key=YOUR_API_KEY&signature=YOUR_SIGNATURE";


        WWW www = new WWW(urlMap);

        yield return www;

        imageMap.texture = www.texture;
        latitudText.text = "" + latitud;
        longitudText.text = "" + longitud;


    }
}
