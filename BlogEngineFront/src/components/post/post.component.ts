import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Post } from 'src/models/post.model';
import { IPost } from './post.class';
import { PostService } from '../../services/post.service';
import { ActivatedRoute, Router} from '@angular/router';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css'],
  providers:[PostService]
})
export class PostComponent implements OnInit {

  checkoutForm: any;
  post: Post = new Post();
  router: Router = new Router;
  editMode: boolean = false;
  postId!: number;
  today = Date.now()
  date: Date = new Date(this.today);

 constructor(
  private fb: FormBuilder,
  private postService: PostService,
  public activatedRoute: ActivatedRoute
  ) {
      this.checkoutForm = this.fb.group({
        id:0,
        title: "",
        content: "",
        createdAt: this.date,
        status: "published",
        author: ""
        
       });
   }

 ngOnInit(){ 
  this.activatedRoute.params.subscribe(params => {
    if(params['id'] === undefined){
      return;
    }
      this.editMode = true;
      this.postId = Number(params['id']);
      this.getDataById(this.postId.toString())
      
   })
  }
  
  public async getDataById(id: string) {
    //console.log(id);
    (await this.postService.getPosts(id)).subscribe(
      (resp: any)=> {
      this.getDataForm(resp), 
        (error: any) => console.error(error)
    })
  }

  getDataForm(data: any) {
    //var dp = new DatePipe(navigator.language);
    //var format = "dd-MM-yyyy";
    this.checkoutForm.patchValue({
      id: data.id,
      title: data.title,
      content: data.content,
      createdAt: data.createdAt,
      status: data.status,
      author: data.author,
     
    });
  }

  async onSubmit(){
    //Process fillout data here
    this.post.Id = this.checkoutForm.value.id;
    this.post.Title = this.checkoutForm.value.title;
    this.post.Content = this.checkoutForm.value.content;
    this.post.CreatedAt = this.checkoutForm.value.createAt;
    this.post.Status = this.checkoutForm.value.status;
    this.post.Author = this.checkoutForm.value.autor;
    
    const data = this.checkoutForm.value;

    //Add and Update post
    if(this.editMode === true)
    {   
      try {
        await this.postService.UpdatePost(this.postId.toString(), data);
        alert("Update Successful");
        this.checkoutForm.reset();
        this.router.navigate(['home']);
        
      } catch (error) {
        console.log(error);
        alert("Update Failed");
      }

    } else {

      try{
        await this.postService.SendPost(data);
        alert("Registration Successful");
       
        //this.router.navigate(['home/home']);
        
      }
        catch (error) {
        console.log(error);
        alert("Registration Failed");
      }
      this.checkoutForm.reset();
      //this.router.navigate(['home']);
    }
  }
}

