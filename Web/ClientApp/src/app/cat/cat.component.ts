import { Component, ElementRef, OnInit } from '@angular/core';
import { Cat } from './cat';
import { CatService } from './cat.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-cat',
  templateUrl: './cat.component.html',
  styleUrls: ['./cat.component.css']
})
export class CatComponent implements OnInit {

  constructor(private catService: CatService, private elRef: ElementRef) { }

  cats: Cat[];
 

  ngOnInit() {
    this.catService.get().subscribe(data => {
      this.cats = data;
    });
  }

  new() {
    this.elRef.nativeElement.querySelector('.myform').style.visibility = 'visible';
    console.log("new");
  }

  submit(form: NgForm) {

    var cat = new CatDetails();
    cat.name = form.value.name;
    cat.age = form.value.age;

    this.catService.post(cat, this);

    this.elRef.nativeElement.querySelector('.myform').style.visibility = 'hidden';
  }
}


export class CatDetails implements Cat {

  id: number;
  name: string;
  age: number;
}
