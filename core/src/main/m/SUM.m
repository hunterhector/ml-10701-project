function outmat = SUM( inmat )
%UNTITLED Summary of this function goes here
%   Detailed explanation goes here
mat = zeros(size(inmat,1),1);
for i=1:size(inmat,1)
    for j=1:size(inmat,2)
        mat(i) = mat(i)+inmat(i,j);
    end
end
outmat=mat;
end

