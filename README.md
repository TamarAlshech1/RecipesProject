# Recipe Website

A full-stack recipe management application where users can browse, add, update, and delete recipes. Built with **React** (frontend) and **ASP.NET Core Web API** (backend) with a **SQL Server** database.

## Key Features

- User registration and authentication
- Add, edit, delete, and view recipes
- Manage recipe ingredients and quantities
- Filter recipes by difficulty, time, or servings
- Responsive UI with Bootstrap

## Technologies

- **Frontend:** React, Redux, Bootstrap, Axios
- **Backend:** ASP.NET Core Web API
- **Database:** SQL Server

## Project Structure

### Backend
- `DAL` – Data access layer
- `DTO` – Data transfer objects
- `BL` – Business logic layer
- `Controllers` – API endpoints

### Frontend
- `Components` – Reusable UI components
- `Redux` – State management (actions, reducers, store)
- `Axios` – API calls

## Setup & Installation

```bash
# 1. Clone the repository
git clone <repository-url>

# 2. Set up the SQL database and update connection strings

# 3. Run the ASP.NET Core Web API

# 4. Start the frontend
npm install
npm start

# 5. Open the application in your browser
