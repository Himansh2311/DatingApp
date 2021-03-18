import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-server-error',
  templateUrl: './server-error.component.html',
  styleUrls: ['./server-error.component.css']
})
export class ServerErrorComponent implements OnInit {
error: any;
  constructor(private router: Router) {
    const navigation=this.router.getCurrentNavigation();
    // use the conditional chaining to be on safer side
    // if we are not sure either the values are present or not
    this.error=navigation?.extras?.state?.error;
   }

  ngOnInit(): void {
  }

}
