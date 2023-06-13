import { Component } from '@angular/core';
import { ICotizacion } from './modelos/cotizacion.interface';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DemoPrueba';
  cotizaciones: ICotizacion[] | undefined

  constructor(){
    this.cotizaciones = []
    this.cotizaciones.push({valor:1,cryptomoneda:"BTC"})
    this.cotizaciones.push({valor:5,cryptomoneda:"CTB"})
    this.cotizaciones.push({valor:4,cryptomoneda:"CBV"})
  }
  pedirCotizacion()
  {
    console.log(this.cotizaciones)
  }
}

