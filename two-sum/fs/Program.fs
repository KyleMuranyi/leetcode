let twoSum (nums: int[]) (target:int) =
    let mutable found = false
    for i in 0 .. nums.Length - 1 do
        for j = i + 1 to nums.Length - 1 do
            if nums.[i] + nums.[j] = target then
                found <- true
                [{i},{j}]
