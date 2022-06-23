import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'test';
  showAllBox = false;
  unit = 3; 
  name = "YOKOGOWA"
  charArray = [];
  unitArray = [];

  showAllBoxes(){
    this.showAllBox = !this.showAllBox;
  }

  ngOnInit(){
    this.unitArray = Array(this.unit).fill(0).map((x,i)=>i)
    this.charArray = this.name.split('');
    console.log(this.charArray);
  }

  showLabel(num){
    const displayName = this.name.substring(this.unit * (num-1),this.unit* (num-1) + this.unit)
   document.getElementById('label-text').textContent = `${displayName}`;
  }

}
