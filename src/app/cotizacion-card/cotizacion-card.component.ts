import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-cotizacion-card',
  templateUrl: './cotizacion-card.component.html',
  styleUrls: ['./cotizacion-card.component.css']
})
export class CotizacionCardComponent {
@Input() valor: number = 0;
@Input() cryptomoneda: string = "";
}
