Desarrollo API rest en C# que obtiene datos de prueba a traves de la invocación a la API https://sandbox-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest.
Consta de un único endpoint que recibe como parametro un valor en dolares y, teniendo en cuenta las cryptomonedas listadas en una variable (más detalle en la siguiente línea), devuelve el calculo del valor ingresado por el usuario multiplicado por la cotizacion actual devuelta por la API de CoinMarketCap.
Posee 2 variables configurables en el archivo appsettings.json, correspondientes a la definicion de la app-key y a la lista de nombres de las cryptomonedas que deben ser tenidas en cuenta a la hora de invocat la api de CoinMarketCap.

Aclaracion:
Tuve un inconveniente al tratar de obtener desde la API de CoinMarketCap el valor del dato "symbol" (segun la documentacion, deberia devolverme las siglas de cada moneda, ej BTC para el caso de "bitcoin").
Al traer ese dato, me devuelve codigos muy largos que no se corresponden en ningun caso a las siglas de las distintas cryptomonedas (entiendo que quizas al usar la API sand-box que posee datos de prueba, quizas ese dato está encriptado para no ver los reales de produccion, o sin simplemente datos dummy).
Lo que hice para solventar esa inconsistencia fue utilizar el campo "slug" (el nombre completo de la cryptomoneda, es decir mostrar "Bitcoin" en vez de "BTC").

