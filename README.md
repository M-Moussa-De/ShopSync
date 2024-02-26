# ShopSync

This project is a multi vendors e-commerce store built with a variety of modern technologies.

## Overview

- Vendors can signup and signin thats how they gain access to Vendors-Dashboard, where they can add, update, and delete their products.

- Users can add products to their cart and place an order. Users can also search for products, filter products by category and price, sort products by price and rating, review and rate products, add products to their wishlist, and checkout their cart. Users can also pay for their orders using Stripe. Users receive an email after placing an order. The application logs are stored in a file. Products are paginated and cached in Redis to improve performance. Admins can manage users and vendors. They can also view orders and products. Users can sign up using social media accounts like Google or Facebook in addition to the traditional email and password. 
Users can sign in, and sign out. Users can also reset their password if they forget it. Users can only access certain parts of the application if they are authorized to do so.

- Admin can manage users and vendors. They can view orders and products.

## Features

- **Authentication:** Users can sign up, sign in, and sign out. Users can also reset their password if they forget it.
- **Authorization:** Users can only access certain parts of the application if they are authorized to do so.
- **Product Management:** Vendors can add, update, and delete their products.
- **Order Management:** Users can add products to their cart and place an order.
- **Search:** Users can search for products.
- **Filtering:** Users can filter products by category and price.
- **Sorting:** Users can sort products by price and rating.
- **Rating & Review:** Users can review and rate products.
- **Wishlist:** Users can add products to their wishlist.
- **Cart:** Users can add products to their cart.
- **Checkout:** Users can checkout their cart.
- **Payment:** Users can pay for their orders using Stripe.
- **Checkout Email:** Users receive an email after placing an order.
- **Logging:** The application logs are stored in a file.
- **Pagination:** Products are paginated.
- **Caching:** Products are cached in Redis to improve performance.
- **Admin Dashboard:** Admins can manage users and vendors. They can also view orders and products.
- **Vendors Dashboard:** Vendors can manage their products and view their orders.
- **Testing:** The application is tested using Jest and xUnit.

## Used Tools & Technologies

**Frontend:**

- Next.js
- ReactJS
- Tailwind CSS
- ReduxJS

**Backend**

- ASP.Net Core Web API
- Entity Framework Core (EF Core)
- Identity

**Architecture**

- Onion/Clean Arcture (Infrastrucutre, Core, Application, Presentation)
- Domain-Driven Design (DDD)
<!-- - Test-Driven Development (TDD) -->

**Database**

- SQL Server

**In Memory Cache**

- Redis

**Payment:**

- Stripe

**DevOps**

- GitHub
- Docker
- Docker Compose
- Jenkins
- Kubernetes (K8s)

**Authentication**

- JWT

**Testing**

- Frontend: Jest
- Backedn: xUnit

## Images

![Home](https://user-images.githubusercontent.com/56729873/134768073-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Products](https://user-images.githubusercontent.com/56729873/134768076-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Product](https://user-images.githubusercontent.com/56729873/134768076-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Cart](https://user-images.githubusercontent.com/56729873/134768077-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Orders](https://user-images.githubusercontent.com/56729873/134768078-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Checkout](https://user-images.githubusercontent.com/56729873/134768078-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Checkout Email](https://user-images.githubusercontent.com/56729873/134768079-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Signup](https://user-images.githubusercontent.com/56729873/134768079-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Signin](https://user-images.githubusercontent.com/56729873/134768079-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Reset Password](https://user-images.githubusercontent.com/56729873/134768079-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Admin Dashboard](https://user-images.githubusercontent.com/56729873/134768079-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)

![Vendors Dashboard](https://user-images.githubusercontent.com/56729873/134768080-3e3e3e3e-3e3e-3e3e-3e3e-3e3e3e3e3e3e.png)
