import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { Navbar } from './components/shared/navbar/navbar';
import { RouterOutlet } from '@angular/router';

@Component({
  selector: 'app',
  imports: [CommonModule, Navbar, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
})
export class AppComponent {



  constructor() {


  }
}
