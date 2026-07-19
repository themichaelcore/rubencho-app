import { Component } from '@angular/core';
import { RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-pedidos',
  imports: [RouterLink, RouterOutlet],
  templateUrl: './pedidos.html',
  styleUrl: './pedidos.css',
})
export class Pedidos {}
