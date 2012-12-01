import os
import sys
from collections import defaultdict
#op=open('loc_feature','r+')

print 'Citing,Cited,F3,S3,L3'
for f in os.listdir("summaries"):
	g=""

	dic=defaultdict(lambda: [0,0,0])
	try:
		g= open('cleaned/'+str(f).replace('.cs','.txt')).read()
	except :
		print'Fuck you assholes!'
		continue
	l = len(g)
	lines= open('summaries/'+f,'r+').readlines()
	if (len(lines)<2):
		continue
	i=0
	while(i < len(lines)):
		f3=0
		s3=0
		l3=0
		loc=-1
		while not (g.find(lines[i],loc+1)== -1):
			loc=g.find(lines[i],loc+1)
			if loc< ((1.0*l)/3.0):
				f3 += 1
			elif loc > ((2.0*l)/3.0):
				l3 +=1
			else:
				s3 +=1
		for cited in lines[i+1].split():
			dic[str(f).strip('.cs')+','+cited][0] += f3
			dic[str(f).strip('.cs')+','+cited][1] += s3
			dic[str(f).strip('.cs')+','+cited][2] += l3
		i=i+2

	for key, value in dic.items():
		print "%s,%d,%d,%d" % (key, value[0], value[1], value[2])

