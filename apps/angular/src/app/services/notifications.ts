import { Injectable } from '@angular/core';
import Swal from 'sweetalert2';

@Injectable({
  providedIn: 'root',
})
export class Notifications {

  success(title: string, text?: string) {
    Swal.fire({ icon: 'success', title, text, timer: 2000, showConfirmButton: false });
  }

  error(title: string, text?: string) {
    Swal.fire({ icon: 'error', title, text });
  }
  
  confirmation() {
    Swal.fire({
      title: '¿Estás seguro?',
      text: 'No podrás revertir esta acción',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Sí, borrar',
      cancelButtonText: 'Cancelar'
    }).then((result) => {
      if (result.isConfirmed) {
        Swal.fire('¡Eliminado!', 'El registro ha sido borrado.', 'success');
      }
    });
  }
}
