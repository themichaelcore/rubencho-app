import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-producto-crear',
  imports: [CommonModule, FormsModule],
  templateUrl: './producto-crear.html',
  styleUrl: './producto-crear.css',
})
export class ProductoCrear {
  @Input() productos: any[] = [];
  
  productoSeleccionado: any = null;
}
