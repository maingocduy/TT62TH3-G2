<template>
    <div class="relative w-full mx-auto overflow-hidden " style="height: calc(1000px);">
        <!-- Hình ảnh -->
        <img src="../../assets/HomeImage/main-background.jpg" alt="Your Image"
            class=" inset-0 w-full h-full object-top  object-cover ">

        <!-- Phần tử overlay -->
        <div class="absolute inset-0">
            <div class="absolute inset-0 bg-gradient-to-t from-white to-transparent opacity-95"></div>
        </div>

        <!-- Chữ đè lên hình ảnh -->
        <div class="absolute inset-0 flex items-center justify-center">
            <p class="text-white text-6xl font-semibold">Tình Nguyện Viên</p>
        </div>
    </div>
    <div class="max-w-[1135px] mx-auto">
        <div class="max-w-[1135px] mx-auto text-[32px]">
            <p class="my-8">Bạn sẽ là một phần của các nỗ lực hỗ trợ trực tiếp và xây dựng năng lực bền vững. Mỗi tình nguyện viên mang đến một bộ kỹ năng riêng và tăng thêm giá trị to lớn cho những người được phục vụ. Mọi người đều được chào đón! 
            </p>
        </div>
    </div>
    <div class="flex flex-wrap justify-around my-20 ">
            <div class=" mb-10 text-center" v-for="(item) in data" :key="item.id">
                <div class="relative">
                    <img class="w-[330px] h-[190px] object-cover" :src=item.image_url alt="">
                    <div class="absolute top-1/2 left-1/2 transform -translate-x-1/2 -translate-y-1/2 text-center">
                        <span class="block text-[#fff] text-3xl font-medium mb-3">{{ item.title }}</span>
                        <button class="border bg-[#FF993A] px-8 py-1 font-medium">Bác sỹ tình nguyện</button>
                    </div>
                </div>
            </div>
        </div>

        <div class="main-bot text-[32px]">
        <div class="container-fluid text-center bg-secondary p-3">
            <p class="my-8">Tham gia cùng chúng tôi tạo nên sự khác biệt
            </p>
          <div class="row justify-content-center">
            <div class="col-3">
              <button class="border bg-[#FF993A] px-8 py-1 font-medium">Tham gia cùng tình nguyện</button>
            </div>
            <div class="col-2">
                <button class="border bg-[#FF993A] px-8 py-1 font-medium"> Quyên góp </button>
            </div>
          </div>
        </div>
      </div>
</template>
    
<script>
export default {
    setup() {
        var data = [
            {
                id: 1,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            },
            {
                id: 2,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }, {
                id: 3,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }, {
                id: 4,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }, {
                id: 5,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }, {
                id: 6,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }, {
                id: 7,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }, {
                id: 8,
                image_url: 'https://tse3.mm.bing.net/th?id=OIP.PMrtYJWOwsb1ya0pxf4etgHaFV&pid=Api&P=0&h=180',
            }
        ];

        return {
            data
        }
    }
}
</script>

<style lang="scss" scoped></style>