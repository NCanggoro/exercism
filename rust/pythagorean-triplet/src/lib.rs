pub fn find() -> Option<i32> {
    let sum = 1000;

    //for a = 3;a < 1000 ; a++
    for a in 3..sum {
        for b in a..sum {
            let c = sum - a - b;
            let target = a * a + b * b == c * c;

            if target {
                return Some(a * b * c);
            }
        }
    };
    None
}
