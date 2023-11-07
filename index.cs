<!DOCTYPE html>
<html lang="en">
<!-- crawler -->
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=2.0">
    <title>Document</title>
    <style>
        /* For mobile device */
        body {
            text-align: center;
            font-size: 16px
        }
        /* For big device */
        @media(min-width: 768px) {
            body {
                font-size: 18px;
            }
        }
        @media(min-width: 768px) {
            .hamburger-menu {
                display: none;
            }
        }
        
        nav {
            display: flex;
            justify-content: space-around;
            background-color: #343;
            padding: 10px;
            color: #fff;
        }
        nav a {
            color: #fff;
            text-decoration: none;
        }
        @media(max-width:768px) {
            nav {
                flex-direction: column;
            }
            .greeting {
                display: none;
            }
        }
        .container {
            display: flex;
            justify-content: space-between;
            padding: 10px;
            background-color: aliceblue;
        }
        @media(max-width:768px) {
            .container {
                flex-wrap: wrap;
            }
        }
    </style>
</head>
<body>
    <nav>
        <!-- Navigation menu items  -->
        <a href="#">Home</a>
        <a href="#">About</a>
        <a href="#">Contact</a>
    </nav>
    <div class="hamburger-menu">&#9776</div>
    <div class="container">
        <main>
            <h1>Welcome to My Blogs</h1>
            <h2 class="greeting">Good to see you</h2>
            <p>Lorem, ipsum dolor sit amet consectetur adipisicing elit. Dolore rerum repellat omnis quos! Asperiores
                sed repudiandae excepturi, aliquid nisi fugiat cum omnis libero doloremque ipsa ea dolores velit
                exercitationem architecto.</p>
        </main>
        <aside>
            <h2>Sidebar</h2>
            <p>Side bar content</p>
        </aside>
    </div>
</body>
</html>