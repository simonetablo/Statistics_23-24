//ARRAY

// Loop through the array
for (let i = 0; i < arr.length; i++) {
    // If the element is 3, skip this iteration
    if (arr[i] === 3) {
        continue;
    }
    // If the element is 5, break the loop
    if (arr[i] === 5) {
        break;
    }
    console.log(arr[i]);
}

// Add an element to the end of the array
arr.push(6);

// Remove the last element from the array
let lastElement = arr.pop();

// Get an element from the array by its index
let firstElement = arr[0];

// Set an element in the array by its index
arr[0] = 7;

//LIST
class List {
    constructor() {
        this.items = [];
    }

    // Add item to the list
    add(item) {
        this.items.push(item);
    }

    // Remove item from the list
    remove(item) {
        const index = this.items.indexOf(item);
        if (index > -1) {
            this.items.splice(index, 1);
        }
    }

    // Get item at a specific index
    get(index) {
        return this.items[index];
    }

    // Set item at a specific index
    set(index, item) {
        this.items[index] = item;
    }

    // Check if the list contains an item
    contains(item) {
        return this.items.includes(item);
    }

    // Get the size of the list
    size() {
        return this.items.length;
    }
}

//DICTIONARY
class Dictionary {
    constructor() {
        this.items = {};
    }

    // Add key-value pair to the dictionary
    add(key, value) {
        this.items[key] = value;
    }

    // Remove key-value pair from the dictionary
    remove(key) {
        delete this.items[key];
    }

    // Get value by key
    get(key) {
        return this.items[key];
    }

    // Set value by key
    set(key, value) {
        this.items[key] = value;
    }

    // Check if the dictionary contains a key
    contains(key) {
        return key in this.items;
    }

    // Get the size of the dictionary
    size() {
        return Object.keys(this.items).length;
    }
}

//SORTED LIST
class SortedList {
    constructor() {
        this.items = [];
    }

    // Add item to the list and sort
    add(item) {
        this.items.push(item);
        this.items.sort((a, b) => a - b);
    }

    // Remove item from the list
    remove(item) {
        const index = this.items.indexOf(item);
        if (index > -1) {
            this.items.splice(index, 1);
        }
    }

    // Get item at a specific index
    get(index) {
        return this.items[index];
    }

    // Check if the list contains an item
    contains(item) {
        return this.items.includes(item);
    }

    // Get the size of the list
    size() {
        return this.items.length;
    }
}

//HASHSET
class HashSet {
    constructor() {
        this.items = {};
    }

    // Add item to the set
    add(item) {
        this.items[item] = true;
    }

    // Remove item from the set
    remove(item) {
        delete this.items[item];
    }

    // Check if the set contains an item
    contains(item) {
        return item in this.items;
    }

    // Get the size of the set
    size() {
        return Object.keys(this.items).length;
    }
}

//SORTED SET
class SortedSet {
    constructor() {
        this.items = [];
    }

    // Add item to the set and sort
    add(item) {
        if (!this.items.includes(item)) {
            this.items.push(item);
            this.items.sort((a, b) => a - b);
        }
    }

    // Remove item from the set
    remove(item) {
        const index = this.items.indexOf(item);
        if (index > -1) {
            this.items.splice(index, 1);
        }
    }

    // Check if the set contains an item
    contains(item) {
        return this.items.includes(item);
    }

    // Get the size of the set
    size() {
        return this.items.length;
    }
}

//QUEUE
class Queue {
    constructor() {
        this.items = [];
    }

    // Add item to the queue
    enqueue(item) {
        this.items.push(item);
    }

    // Remove item from the queue
    dequeue() {
        if (this.isEmpty()) {
            throw new Error("Queue is empty");
        }
        return this.items.shift();
    }

    // Check if the queue is empty
    isEmpty() {
        return this.items.length === 0;
    }

    // Get the size of the queue
    size() {
        return this.items.length;
    }

    // Get the front item of the queue
    front() {
        if (this.isEmpty()) {
            throw new Error("Queue is empty");
        }
        return this.items[0];
    }
}

//STACK
class Stack {
    constructor() {
        this.items = [];
    }

    // Add item to the stack
    push(item) {
        this.items.push(item);
    }

    // Remove item from the stack
    pop() {
        if (this.isEmpty()) {
            throw new Error("Stack is empty");
        }
        return this.items.pop();
    }

    // Check if the stack is empty
    isEmpty() {
        return this.items.length === 0;
    }

    // Get the size of the stack
    size() {
        return this.items.length;
    }

    // Get the top item of the stack
    top() {
        if (this.isEmpty()) {
            throw new Error("Stack is empty");
        }
        return this.items[this.items.length - 1];
    }
}

//LINKED LIST
class Node {
    constructor(data) {
      this.data = data;
      this.next = null;
    }
}
  
  class LinkedList {
    constructor() {
      this.head = null;
      this.size = 0;
    }
  
    // Add a new node to the end of the list
    append(data) {
      const newNode = new Node(data);
      if (!this.head) {
        this.head = newNode;
      } else {
        let current = this.head;
        while (current.next) {
          current = current.next;
        }
        current.next = newNode;
      }
      this.size++;
    }
  
    // Insert a new node at a specific index
    insert(data, index) {
      if (index < 0 || index > this.size) {
        return false; // Index out of bounds
      }
      const newNode = new Node(data);
      if (index === 0) {
        newNode.next = this.head;
        this.head = newNode;
      } else {
        let current = this.head;
        for (let i = 0; i < index - 1; i++) {
          current = current.next;
        }
        newNode.next = current.next;
        current.next = newNode;
      }
      this.size++;
      return true;
    }
  
    // Remove a node at a specific index
    remove(index) {
      if (index < 0 || index >= this.size) {
        return null; // Index out of bounds
      }
      if (index === 0) {
        const removedNode = this.head;
        this.head = this.head.next;
        this.size--;
        return removedNode.data;
      } else {
        let current = this.head;
        for (let i = 0; i < index - 1; i++) {
          current = current.next;
        }
        const removedNode = current.next;
        current.next = current.next.next;
        this.size--;
        return removedNode.data;
      }
    }
  
    // Get the value at a specific index
    get(index) {
      if (index < 0 || index >= this.size) {
        return null; // Index out of bounds
      }
      let current = this.head;
      for (let i = 0; i < index; i++) {
        current = current.next;
      }
      return current.data;
    }
  
    // Get the size of the linked list
    getSize() {
      return this.size;
    }
  
    // Check if the linked list is empty
    isEmpty() {
      return this.size === 0;
    }
}