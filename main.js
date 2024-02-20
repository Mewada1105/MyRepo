function reverseStringOrReject(input) {
  return new Promise((resolve, reject) => {
    setTimeout(() => {
      if (typeof input === 'string') {
        resolve(input.split('').reverse().join(''));
      } else {
        reject(input);
      }
    }, 500);
  });
}

// Example usage:
reverseStringOrReject("hello")
  .then(result => {
    console.log("Resolved:", result);
  })
  .catch(error => {
    console.error("Rejected:", error);
  });

reverseStringOrReject(123)
  .then(result => {
    console.log("Resolved:", result);
  })
  .catch(error => {
    console.error("Rejected:", error);
  });
