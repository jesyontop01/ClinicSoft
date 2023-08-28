import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
//import { BrowserModule } from '@angular/platform-browser';
import { EnglishCalendarService } from './en-calendar.service';
import { EnglishCalendarComponent } from './en-calendar.component';
import { CommonModule } from '@angular/common';

@NgModule({
    providers: [EnglishCalendarService],
    imports: [FormsModule, CommonModule],
    declarations: [
      EnglishCalendarComponent],
    exports: [
      EnglishCalendarComponent
    ]
})
export class EnglishCalendarModule {

}
