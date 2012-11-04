function der = lossDer(x,b)
    e = exp(-x/b);
    der = 1/b *(1+e)*e; 
end

