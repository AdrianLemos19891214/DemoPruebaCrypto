import { Component } from '@angular/core';
import { ICotizacion } from './modelos/cotizacion.interface';
import { CryptoService } from './crypto.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'DemoPrueba';
  cotizaciones: ICotizacion[] | undefined;
  importe: number;
  timeRefresh: ReturnType<typeof setInterval>|undefined;

  constructor(private _cryptoservice: CryptoService){
    this.cotizaciones = []
    this.importe = 0;
  }
  pedirCotizacion()
  {
    if(this.timeRefresh!==undefined)
        {clearInterval(this.timeRefresh)}
          this.timeRefresh = setInterval(()=>{
            console.log("buscando datos",this.importe)
            this._cryptoservice.getCryptoData(this.importe).then(data => this.cotizaciones = data).catch(error=>{console.log(error)
            })
          },5000)
        
          this._cryptoservice.getCryptoData(this.importe).then(data => 
            {
              this.cotizaciones = data              
            }
            ).catch(error=>{console.log(error)
           });
        
     
  }
}

