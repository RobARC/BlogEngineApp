import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BoardWriterComponent } from './board-writer.component';

describe('BoardWriterComponent', () => {
  let component: BoardWriterComponent;
  let fixture: ComponentFixture<BoardWriterComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BoardWriterComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(BoardWriterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
