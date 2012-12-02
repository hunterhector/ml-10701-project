Q = [0.4 0.6;0.2 0.8];

%attributes = [-0.4 0.2 0.3 0.1 -0.1;0.1 -0.2 0.1 0.3 -0.3;0.6 -0.4 0.2 0.1 -0.5];

%we need to import the Q outside and make it sparse
%if (~issparse(Q))
%    Q = sparse(Q);
%end;

n = size(Q,1); %dimension of Q
maxIter = 100;

alpha = 0.2; %restart probablity 

wx=zeros(n,n); %weight on the arcs
w = [0.1 0.2 0.7]; %feature parameters
numFeature = size(w,2); %length of feature parameters


attributes = rand(numFeature,n,n);
attributes(:,1,1)= [-0.1 0.2 -0.1];
attributes(:,1,2)= [0.3 0.2 0.1];
attributes(:,2,1)= [0.2 0.4 0.3];
attributes(:,2,2)= [0.1 0.5 0.1];

for k = 1:n
    for l = 1:n
        att=attributes(:,k,l);
        wx(k,l) = w*att;
    end
end

weightMatrix = arrayfun(@fw,wx)
wtder = zeros(numFeature,n,n);
diffwt = arrayfun(@fwDer,wx);
for j=1:numFeature
    for k = 1:n
        for l = 1:n
      
            att = attributes(j,k,l);
            wtder(j,k,l) = att*diffwt(k,l);
        end
    end
end

wtder

%eigen vector for each iterations
p = ones(maxIter,n);
p = p/n;
wtsum= SUM(weightMatrix)

dwtsum=zeros(numFeature,n);
for i= 1:numFeature
    %k = wtder(i,:,:);
    for j=1:n
        sm=0;
        for l=1:n
            sm = sm + wtder(i,j,l);
        end
        dwtsum(i,j)=sm; %take transpose of single entity when using
    %dwtsum(i)=tsum;
    end
end

dwtsum

wtsumsq= arrayfun(@sqrr,wtsum)

for i=1:numFeature
    for j=1:n
        for k=1:n
            sm= wtder(i,j,k)*wtsum(j);
        
            sm1= weightMatrix(j,k)*dwtsum(i,j);
            term1= sm - sm1;
            term1= term1/wtsumsq(j);
            delQ(i,j,k) = (1-alpha)* term1;
        end
    end
end
   
delQ

%derivatives for each iterations
pdel = zeros(numFeature,maxIter,n);

%stopping criteria
epsilon = 10^-12;

t = 1;
delta = 1;

fprintf('Outputing the iterations of pagerank\n');

while (delta > epsilon && t < maxIter)
   p(t+1,:) = p(t,:)*Q;
   delta = norm(p(t+1,:) - p(t,:),2);
   fprintf('iter = %d, delta=%f\n', t, delta);
   t = t+1;
end

fprintf('Result of pagerank:');
for i = 1:n
    fprintf('%d\t',p(t-1,i));
end
fprintf('\n\n');

fprintf('Outputing the iterations of derivatives\n')

t = 1;
for k = 1:numFeature
%    fprintf('Doing feature %d\n',k);
    delta = 1;
    
    while (delta > epsilon && t< maxIter)
       for j=1:n
           prod=0;
           for l=1:n
            prod = prod + pdel(k,t,j)*Q(j,l)+p(t,j)*delQ(k,j,l);
 %           fprintf('Doing %d*%d + %d*%d\n',pdel(k,t,j),Q(j,l),p(t,j),delQ(k,j,l));
           end
           pdel(k,t+1,j) = prod;
 %          fprintf('Result is %d\n',prod);
       end
       
  %     fprintf('squeeze: t\n')
  %     squeeze(pdel(k,t,:))
       
   %    fprintf('squeeze: t+1\n')
   %    squeeze(pdel(k,t+1,:))
       
       
       delta = norm(squeeze(pdel(k,t+1,:)) - squeeze(pdel(k,t,:)),2);
              
    %   fprintf('\n')
       
       fprintf('iter = %d, delta * 10^15=%f\n', t, delta*10^15); 

       t=t+1;
       
    end
end

pdel(:,t-1,:)