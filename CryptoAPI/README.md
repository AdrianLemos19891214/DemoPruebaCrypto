Desarrollo API rest en C# que obtiene datos de prueba a traves de la invocación a la API https://sandbox-api.coinmarketcap.com/v2/cryptocurrency/quotes/latest.
Consta de un único endpoint que recibe como parametro un valor en dolares y, teniendo en cuenta las cryptomonedas listadas en una variable (más detalle en la siguiente línea), devuelve el calculo del valor ingresado por el usuario multiplicado por la cotizacion actual devuelta por la API de CoinMarketCap.
Posee 2 variables configurables en el archivo appsettings.json, correspondientes a la definicion de la app-key y a la lista de nombres de las cryptomonedas que deben ser tenidas en cuenta a la hora de invocat la api de CoinMarketCap.

