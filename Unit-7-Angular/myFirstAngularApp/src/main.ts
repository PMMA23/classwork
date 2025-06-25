// This starts the Anular application
// when you fo ng serve it looks for main.ts to start app
// this is where you define the component reperesenting the home page

import { bootstrapApplication } from '@angular/platform-browser'; // Starts Angular App
import { appConfig } from './app/app.config'; // Angular app configuration info


// Specify the folder containing the home page and its name 

//import {name -used-in-this-code} from path-to-the-component-files
// the compnent path contains folder and high level name of the component
// The compnent path is relative to src folder
// .app/app
//
// /app - the folder named app in the folder you are in
// /app - all files related to the component will start with app
import { App } from './app/app'; // Get the Angular component stuff from ./app/app

bootstrapApplication(App, appConfig)
  .catch((err) => console.error(err));
