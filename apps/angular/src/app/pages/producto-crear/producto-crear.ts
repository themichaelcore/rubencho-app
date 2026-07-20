import { Component, Input } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-producto-crear',
  imports: [CommonModule, FormsModule, ReactiveFormsModule],
  templateUrl: './producto-crear.html',
  styleUrl: './producto-crear.css',
})
export class ProductoCrear {
  @Input() productos: any[] = [];
  @Input() acompanamientos: any[] = [];
  
  productoSeleccionado: any = null;
  
  form = new FormGroup({
    comentarios: new FormControl(''),
  });
}
