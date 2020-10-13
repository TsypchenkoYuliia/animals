import { Component, ElementRef, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Dog } from './dog';
import { DogService } from './dog.service';

@Component({
  selector: 'app-dog',
  templateUrl: './dog.component.html',
  styleUrls: ['./dog.component.css']
})
export class DogComponent implements OnInit {

  constructor(private dogService: DogService, private elRef: ElementRef) { }

  dogs: Dog[];

  ngOnInit() {
    this.dogService.get().subscribe(data => {
      this.dogs = data;
    });
  }

  new() {
    this.elRef.nativeElement.querySelector('.myform').style.visibility = 'visible';
    console.log("new");
  }

  submit(form: NgForm) {

    var dog = new DogDetails();
    dog.name = form.value.name;
    dog.age = form.value.age;

    this.dogService.post(dog, this);

    this.elRef.nativeElement.querySelector('.myform').style.visibility = 'hidden';
  }
}


export class DogDetails implements Dog {

  id: number;
  name: string;
  age: number;
}

