<!DOCTYPE html>
<html lang="en">
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>User Profile</title>
</head>
<body>
  <div id="profile">
    <h1>User Profile</h1>
    <p id="name">Name: </p>
    <p id="email">Email: </p>
    <p id="phone">Phone: </p>
    <!-- Add more profile information here -->
  </div>

  <script>
    document.addEventListener('DOMContentLoaded', () => {
      fetchUserData();
    });

    function fetchUserData() {
      fetch('https://fakestoreapi.com/users/1')
        .then(response => {
          if (!response.ok) {
            throw new Error('Failed to fetch user data');
          }
          return response.json();
        })
        .then(userData => {
          updateProfile(userData);
        })
        .catch(error => {
          console.error('Error fetching user data:', error.message);
        });
    }

    function updateProfile(userData) {
      const nameElement = document.getElementById('name');
      const emailElement = document.getElementById('email');
      const phoneElement = document.getElementById('phone');
      
      // Update profile information
      nameElement.textContent += userData.name;
      emailElement.textContent += userData.email;
      phoneElement.textContent += userData.phone;
      // Add more profile information updates here if needed
    }
  </script>
</body>
</html>
