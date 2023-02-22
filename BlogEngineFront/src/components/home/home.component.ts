import { Component, OnInit, Output } from '@angular/core';
import { Post } from 'src/models/post.model';
import { HomeService } from 'src/services/home.service';
import { IPost } from 'src/components/post/post.class';
import { ActivatedRoute } from '@angular/router';
import { FormBuilder, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit{

  posts: any
  postsForm: any
  editmode: boolean = false;
  postsId: string = "";
  formGroup!: FormGroup;
  checkoutForm: any;


  constructor(
    private fb: FormBuilder,
    private homeService: HomeService,
    
  
   ) { }

  async ngOnInit() {

    this.getData();
  }

  public async deletePost(postId: string) {
    try {
      (await this.homeService.DeletePost(postId));
      alert("Delete post successfully")
    } catch (error) {
      console.error(error);
    }
    this.getData();
    
  }

  public async getData(){
    (await this.homeService.getPost()).subscribe((resp: any) => {
    
      this.posts = resp;
     });
    }
  }


