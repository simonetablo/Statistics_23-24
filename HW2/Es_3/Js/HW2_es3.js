function generateRandomVariates(N, k) {
    var variates = [];
    var distribution = Array(k).fill(0);

    for (var i = 0; i < N; i++) {
        var randomNum = Math.random();
        variates.push(randomNum);
        var index = Math.floor(randomNum * k);
        distribution[index]++;
    }

    return { variates: variates, distribution: distribution };
}

var N = 100000; // Number of random variates
var k = 100; // Number of class intervals
var result = generateRandomVariates(N, k);

console.log("Random Variates: ", result.variates);
console.log("Distribution: ", result.distribution);