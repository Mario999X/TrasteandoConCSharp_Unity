# TrasteandoConCSharp_Unity

Primeros proyectos realizados usando el lenguaje [C#](https://learn.microsoft.com/es-es/dotnet/csharp/) y el motor gráfico [Unity](https://unity.com/es), siguiendo tutoriales por parte de la *comunidad* como *oficiales*, como proyectos propios usando la documentación.

## [First Game Unity](FirstGameUnity)

Réplica del tutorial ofrecido en un [video de Youtube](https://youtu.be/XtQMytORBmM).

## [Consumir una API -- Parte I](ConsumeAPI)

Uso de [HttpClient](https://learn.microsoft.com/es-es/dotnet/api/system.net.http.httpclient?view=net-7.0) y [JsonUtility](https://docs.unity3d.com/ScriptReference/JsonUtility.html) para consumir la [PokéAPI](https://pokeapi.co) y mostrar el json obtenido y datos relevantes del mismo, así como controlar errores en la búsqueda realizada.

Se han consultado las siguiente [fuente](https://stackoverflow.com/questions/67518576/unity-jsonutility-doesnt-properly-convert-string-to-an-object/67524112#67524112) a la hora de realizar el paso string json a objeto json.

## [First Game Unity V2](FirstGameUnity_V2)

Versión mejorada con las siguientes adiciones:

- [Menú de Pausa](https://www.youtube.com/watch?v=ROwsdftEGF0&t=66s)
- [Efectos Sonoros](https://levelup.gitconnected.com/how-to-play-sound-effects-in-unity-6a122bb32970)
- [Cambio de Escena](https://www.youtube.com/watch?v=YVATrLTZZTk) (Menú Principal).

## [Lectura y Escritura de Ficheros](LecturaEscrituraFicheros)

Uso de [StreamWriter](https://learn.microsoft.com/en-us/dotnet/api/system.io.streamwriter?view=net-7.0) y [StreamReader](https://learn.microsoft.com/en-us/dotnet/api/system.io.streamreader?view=net-7.0) para almacenar datos de manera persistente. Se ha seguido el siguiente [tutorial](https://www.youtube.com/watch?v=aSNj2nvSyD4).

## [Player Preferences & Internacionalización](PlayerPreferencesAndInternacionalizacion)

Siguiendo el siguiente [tutorial](https://www.youtube.com/watch?v=jjLr0MFlZWQ) y la [documentación oficial](https://docs.unity3d.com/530/Documentation/ScriptReference/PlayerPrefs.html#:~:text=On%20Mac%20OS%20X%20PlayerPrefs,%5Bproduct%20name%5D.) se ha realizado un almacenamiento de datos persistentes del jugador.

Estos datos son almacenados en las siguientes ubicaciones según el SO usado:

- **Windows** (registro/regedit):  HKCU\Software\[nombre de la empresa]\[nombre del producto] key

- **Linux**: ~/.config/unity3d/[NombreDeLaEmpresa]/[NombreDelProducto]

- **Mac OS**: ~/Library/Preferences directorio, en un archivo nombrado unity.[nombre de la empresa].[nombre del producto].plist


Para la internacionalización, se ha seguido el siguiente [tutorial](https://www.youtube.com/watch?v=qcXuvd7qSxg).

## [Consumir una API -- Parte II](ConsumeAPI_II)

Haciendo uso de una [API que permite POST](https://jsonplaceholder.typicode.com/), mostramos por terminal las respuestas recibidas.

## [First Game Unity V3](FirstGameUnity_V3)

Versión mejorada con las siguientes adiciones:

- Opción de regresar al menú principal desde el menú de pausa.
- Si el pájaro sale de la pantalla (zona superior o inferior), la partida se perderá.
- Capacidad de ver la puntuación más alta obtenida de anteriores partidas y poder actualizarla.
- Comentarios agregados para facilitar el código.

## [Point & Shoot](PointAndShoot)

- Demostración básica de colisiones entre [Colisiones 2D](https://docs.unity3d.com/ScriptReference/Collision2D.html), y cómo diferenciar la colisión entre dos **Game Object** según su *nombre*.

- Mecánica de seguimiento del puntero del ratón, y de disparo. Se siguió el siguiente [tutorial](https://www.youtube.com/watch?v=LqrAbEaDQzc&list=WL&index=1&t=6s).