import { Component, OnInit } from '@angular/core';
import { BpressureService } from '../services/bpressure.service';
import { Bpressure } from '../models/bpressure';
import { NgForm } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  bpressure = {} as Bpressure;
  bpressures: Bpressure[];

  constructor(private  bpressureService: BpressureService, private _route: ActivatedRoute) { }

  ngOnInit(): void {
    if (this._route.snapshot.paramMap.get('id') !== null) {
      this.getCarById(Number(this._route.snapshot.paramMap.get('id')));
    }
  }

  saveCar(form: NgForm) {
    if (this.bpressure.bPressureId !== undefined ) {
      this.bpressureService.updateCar(this.bpressure).subscribe(() => {
        this.cleanForm(form);
      });
    } else {
      this.bpressureService.saveCar(this.bpressure).subscribe(() => {
        this.cleanForm(form);
      });
    }
  }

  getCarById(id: number) {
    if (id !== null) {
      this.bpressureService.getCarById(id).subscribe((bpressure: Bpressure) => {
        this.bpressure = bpressure;
      });
    }
  }

  // limpa o formulario
  cleanForm(form: NgForm) {
    form.resetForm();
    this.bpressure = {} as Bpressure;
  }

}
