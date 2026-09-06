import { Component, inject } from '@angular/core';
import { AsyncPipe } from '@angular/common';
import { DbOperations } from '../../services/db-operations';
import { GetPedido } from '../../models/interfaces';
import { PedidoCard } from "../pedido-card/pedido-card";
import { Observable } from 'rxjs';

@Component({
  selector: 'app-pedido-consultar',
  imports: [PedidoCard, AsyncPipe],
  templateUrl: './pedido-consultar.html',
  styleUrl: './pedido-consultar.css',
})
export class PedidoConsultar{
  private dbService = inject(DbOperations);
  pedidos$: Observable<GetPedido[]> = this.dbService.getPedidos();
}
