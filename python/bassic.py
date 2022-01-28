# to prent some thing on screen
print("hellow")

# varibale

x =  6
print(x)

# string formatiign

print(f'hellow world i ma {x}')

# sting concatinaiton
# y = input('gibe a name')   # input 
# print('hellow world ' + y ) 


#  multi line  out put
print(f'''   hello world have greatly take by all the programes 
 and till its very famous  {x} ''')


# types of data
# stry
x = "ravi"
print(type(x) ,'eg' , f'{x}')

#int
x = 4
print(type(x) ,'eg' , f'{x}')

#float
x = 6.6
print(type(x) ,'eg' , f'{x}')


#complex
x = 6j
print(type(x) ,'eg' , f'{x}')

#list
x = ["apple", "banana", "cherry"]
print(type(x) ,'eg' , f'{x}')



#touple
x = ("apple", "banana", "cherry")
print(type(x) ,'eg' , f'{x}')



#dirrectory or dishnary
x = {"name":"ravi","surname" :"pal"}
print(type(x) ,'eg',f'{x}')


#  set
x = {"ravi" , 2, "pal" , 23, 34}
print(type(x) ,'eg',f'{x}')


#bollen
x = True
print(type(x) ,'eg',f'{x}')




#range
x = range(6)
print(type(x) ,'eg',f'{x}')



# string operation
# indexing
x = "my name is ravi"
print(len(x))
print(x[1],"indexing in string a[1] of", x)


# for looping in strign
for  x in "ravi":
    print(x)

x = "my name is ravi"
if "ravi" in x:
    print(f"""yes ravi is present in "{x}" sting""" )

print('ravi' not in x ) #gitve buolen


# string slicing 
b = "my self ravi"
print(b[2:])
print(b.upper())
print(b.lower())
print(b.replace('ravi','ram'))


# there is alotes of methon in list


# +  - * / %  are arthimatic opearators
# % is modulust give sreminiter of diviiosn thins are used 

# assingment operators are 
# = 
# += 
# -=
# *=


# comparison oprtor
# ==
# >=
# <=
# ===
# !=


# bitwise operators 
# and  &
# or ||
# not ~



# conditional operators if else
x = "ravi"

if "r" in x :
    print("r in given strign")
elif('y' in x):
    print("y in the given strng")
else:
    print("nothing")



# loops  for loops  ,while loops, for each loots
for x in range(10):
    print(x)
    
 
x=0
print("while loop")
while(x<4):
    print(x)
    x=x+1
    
x = ["apple", "banana", "cherry"]
for  i in x :
    print(i)






# excepton handeling

try:
    x=1
    print(
        x/0
    )

except:
    print('some error')

finally:
    print("its me whill be print all the time")



# next oppos  





