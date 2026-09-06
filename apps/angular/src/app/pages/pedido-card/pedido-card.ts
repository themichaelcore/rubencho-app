import { Component, input, OnChanges, SimpleChanges } from '@angular/core';
import { GetPedido } from '../../models/interfaces';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-pedido-card',
  imports: [DatePipe],
  templateUrl: './pedido-card.html',
  styleUrl: './pedido-card.css',
})
export class PedidoCard implements OnChanges{

  pedido = input<GetPedido>();
  colorFondo: string = 'white';

  ngOnChanges(changes: SimpleChanges): void {
    this.setColor();
  }
  
  setColor() {
    switch (this.pedido()?.idEstado) {
      case 1:
        this.colorFondo = 'yellow';
        break;
      case 2:
        this.colorFondo = 'orange';
        break;    
      case 3:
        this.colorFondo = 'cyan';
        break;
      case 4:
        this.colorFondo = 'rgb(2, 255, 6)';
        break;
      case 5:
        this.colorFondo = 'red';
        break;
      default:
        this.colorFondo = 'white';
    }
  }
}
